using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Microsoft.Win32;
using ISlideshowEffect;

namespace Wpf_Lab2_Wed {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        //private string pluginspath = AppDomain.CurrentDomain.BaseDirectory;
        //private ObservableCollection<PluginName> _namesxd = new ObservableCollection<PluginName>();
        //public ObservableCollection<PluginName> Namesxd {
        //    get;set;
        //}
        public List<ISlideshowEffect.ISlideshowEffect> pluginsxd = new List<ISlideshowEffect.ISlideshowEffect>();
        public MainWindow() {
            InitializeComponent();
            //this.Namesxd = new ObservableCollection<PluginName>();
            foreach (string s in Directory.GetLogicalDrives()) {
                myTreeItem item = new myTreeItem(s);
                item.Header = s;    
                item.Tag = s;
                item.FontWeight = FontWeights.Normal;
                item.Items.Add(dummyNode);
                item.Expanded += new RoutedEventHandler(folder_Expanded);
                trvMenu.Items.Add(item);
            }
            LoadPlugins();
            //System.Windows.MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory.ToString());
        }

        private void LoadPlugins() {
            //loading plugins
            string[] dllFileNames = null;
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory)) {
                dllFileNames = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
            }

            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
            foreach (string dllFile in dllFileNames) {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }
            Type pluginType = typeof(ISlideshowEffect.ISlideshowEffect);
            ICollection<Type> pluginTypes = new List<Type>();
            foreach (Assembly assembly in assemblies) {
                if (assembly != null) {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types) {
                        if (type.IsInterface || type.IsAbstract) {
                            continue;
                        } else {
                            if (type.GetInterface(pluginType.Name) != null) {
                                pluginTypes.Add(type);
                            }
                        }
                    }
                }
            }
            //ICollection<ISlideshowEffect.ISlideshowEffect> plugins = new List<ISlideshowEffect.ISlideshowEffect>(pluginTypes.Count);
            foreach (Type type in pluginTypes) {
                ISlideshowEffect.ISlideshowEffect plugin = (ISlideshowEffect.ISlideshowEffect)Activator.CreateInstance(type);
                //plugins.Add(plugin);
                pluginsxd.Add(plugin);
            }

            List<string> pluginnames = new List<string>();
            //List<PluginName> namesxd = new List<PluginName>();
            foreach (ISlideshowEffect.ISlideshowEffect plugin in pluginsxd) {
                //System.Windows.MessageBox.Show(plugin.Name);
                pluginnames.Add(plugin.Name);
                //Namesxd.Add(new PluginName(plugin.Name));
            }
            effectComboBox.DataContext = pluginsxd;
            startslideshowMenuItem.DataContext = pluginsxd;
        }

        private void folder_Expanded(object sender, RoutedEventArgs e) {
            myTreeItem item = (myTreeItem)sender;
            if (item.Items.Count == 1 && item.Items[0] == dummyNode) {
                item.Items.Clear();
                try {
                    foreach (string s in Directory.GetDirectories(item.Tag.ToString())) {
                        myTreeItem subitem = new myTreeItem(s);
                        subitem.Header = s.Substring(s.LastIndexOf("\\") + 1);
                        subitem.Tag = s;
                        subitem.FontWeight = FontWeights.Normal;
                        subitem.Items.Add(dummyNode);
                        subitem.Expanded += new RoutedEventHandler(folder_Expanded);
                        item.Items.Add(subitem);
                    }
                } catch (Exception) { }
            }
        }

        private object dummyNode = null;


        private void MenuExit_Click(object sender, RoutedEventArgs e) {
            System.Windows.Application.Current.Shutdown();

        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e) {
            List<ImgInfo> images = new List<ImgInfo>();
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Open Folder";
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK) {
                string path = dialog.SelectedPath;
                DirectoryInfo folder = new DirectoryInfo(path);
                if (folder.Exists) {
                    foreach (FileInfo finfo in folder.GetFiles()) {
                        if (finfo.Extension == ".jpg" || finfo.Extension == ".png" || finfo.Extension == ".PNG" || finfo.Extension == ".JPG") {
                            try {
                                BitmapImage xd = new BitmapImage(new Uri(finfo.FullName));
                                images.Add(new ImgInfo(finfo.Name, xd.Width, xd.Height, finfo.Length));
                            } catch { new Exception("Wrong extenstion"); }
                        }
                    }
                }
                foreach (ImgInfo img in images) {
                    img.FullPath = path + "\\" + img.Name;
                }
            }
            this.DataContext = images;
        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e) {
            System.Windows.MessageBox.Show("This is simple image application slideshow", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SourceListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (sourceListView.SelectedIndex == -1) {
                MyDataSource.Instance.IsSelectedXD = false;
            } else {
                MyDataSource.Instance.IsSelectedXD = true;
                fileinfoExpander.IsExpanded = true;
                fileinfoExpander.DataContext = sourceListView.SelectedItem;
            }
        }

        private void TrvMenu_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e) {
            List<ImgInfo> images = new List<ImgInfo>();
            string path = ((myTreeItem)e.NewValue).FilePath;
            DirectoryInfo folder = new DirectoryInfo(path);
            if (folder.Exists) {
                try {
                    foreach (FileInfo finfo in folder.GetFiles()) {
                        if (finfo.Extension == ".jpg" || finfo.Extension == ".png" || finfo.Extension == ".PNG" || finfo.Extension == ".JPG") {
                            try {
                                BitmapImage xd = new BitmapImage(new Uri(finfo.FullName));
                                images.Add(new ImgInfo(finfo.Name, xd.Width, xd.Height, finfo.Length));
                            } catch { new Exception("Wrong extenstion"); }
                        }
                    }
                } catch {
                    new System.UnauthorizedAccessException();
                }
            }
            foreach (ImgInfo img in images) {
                img.FullPath = path + "\\" + img.Name;
            }
            this.DataContext = images;

        }

        private void StartShow_Click(object sender, RoutedEventArgs e) {
            StartSlidesShow(effectComboBox.SelectedIndex);
        }


        // 0 - opacity, 1-horiozntal, 2-vertical
        private void StartSlidesShow(int effect) {
            if (this.DataContext is List<ImgInfo> && pluginsxd.Count>0) {
                if (((List<ImgInfo>)this.DataContext).Count > 0) {
                    SlidesWindow slideWindow = new SlidesWindow(pluginsxd[effect]);
                    slideWindow.ShowDialog();
                } else {
                    System.Windows.MessageBox.Show("The selected folder does not contain any images to start slideshow!", "An error occured", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            } else
                System.Windows.MessageBox.Show("The selected folder does not contain any images or plugins neccessary to start slideshow!", "An error occured", MessageBoxButton.OK, MessageBoxImage.Warning);
            //System.Windows.MessageBox.Show("XD");
        }
        private void StartSlidesShow(ISlideshowEffect.ISlideshowEffect plugin) {
            if (this.DataContext is List<ImgInfo> && pluginsxd.Count>0) {
                if (((List<ImgInfo>)this.DataContext).Count > 0) {
                    SlidesWindow slideWindow = new SlidesWindow(plugin);
                    slideWindow.ShowDialog();
                } else {
                    System.Windows.MessageBox.Show("The selected folder does not contain any images to start slideshow!", "An error occured", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            } else
                System.Windows.MessageBox.Show("The selected folder does not contain any images or plugins neccesasary to start slideshow!", "An error occured", MessageBoxButton.OK, MessageBoxImage.Warning);
            //System.Windows.MessageBox.Show("XD");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) {
            if (pluginsxd.Count > 0) {
                ISlideshowEffect.ISlideshowEffect tmp = pluginsxd.Find(x => x.Name == (string)((System.Windows.Controls.MenuItem)sender).Header);
                StartSlidesShow(tmp);
            } else {
                System.Windows.MessageBox.Show("No plugins avaliable", "EROR ",MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

