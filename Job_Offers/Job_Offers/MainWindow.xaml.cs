using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;

namespace Polska_infa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UploadButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Load img file";
            openFileDialog1.Filter = "Image|*.png;.*bmp;*.jpeg;*.jpg";
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..//..//Resources");
            openFileDialog1.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
            if(openFileDialog1.ShowDialog() == true)
            {
                BitmapSource bs = new BitmapImage(new Uri(openFileDialog1.FileName));
                majaplołdedimidż.Source = bs;
                //majaplołdedimidż.Stretch = Stretch.Fill;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<string> list = new ObservableCollection<string>();
            list.Add("dupa");
            list.Add("test");
            list.Add("1");
            this.Department.ItemsSource = list;
        }
    }
}
