using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;


namespace Wpf_Lab2_Wed {
    /// <summary>
    /// Interaction logic for SlideshowWindow.xaml
    /// </summary>
    public partial class SlidesWindow : Window {

        private DispatcherTimer dtClockTime { get; set; }
        private List<string> imagePaths = new List<string>();
        private int currentIndex=0;
        private string blankimgpath = @"D:\studia\Programming in Graphical Environment\blankimg.png";
        private ISlideshowEffect.ISlideshowEffect plugin;

        public SlidesWindow(ISlideshowEffect.ISlideshowEffect pluginxd) {
            InitializeComponent();
            plugin = pluginxd;
            //currentIndex = 0;
            //imagePaths = new List<string>();

            foreach (ImgInfo i in (List<ImgInfo>)((MainWindow)Application.Current.MainWindow).DataContext) {
                imagePaths.Add(i.FullPath);
            }

            dtClockTime = new DispatcherTimer();
            dtClockTime.Interval = new TimeSpan(0, 0, 5); //in Hour, Minutes, Second.
            dtClockTime.Tick += DtClockTime_Tick;
            dtClockTime.Start();

            //BitmapSource bs = new BitmapImage(new Uri((string)blankimgpath));
            slide.Source = new BitmapImage(new Uri((string)blankimgpath));
            //BitmapSource bs2 = new BitmapImage(new Uri((string)imagePaths[currentIndex]));
            nextslides.Source = new BitmapImage(new Uri((string)imagePaths[currentIndex]));
            plugin.PlaySlideshow(nextslides, slide, 1024, 768);
        }

        private void DtClockTime_Tick(object sender, EventArgs e) {
            int oldindex = currentIndex;
            currentIndex = ++currentIndex % imagePaths.Count;
            //ShowSlide(imagePaths[currentIndex]);

            //BitmapSource bs = new BitmapImage(new Uri((string)imagePaths[oldindex]));
            slide.Source = new BitmapImage(new Uri((string)imagePaths[oldindex]));
            //BitmapSource bs2 = new BitmapImage(new Uri((string)imagePaths[currentIndex]));
            nextslides.Source = new BitmapImage(new Uri((string)imagePaths[currentIndex]));
            plugin.PlaySlideshow(nextslides, slide, 1024, 768);
        }

        private void ShowRightClickMenu(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            ContextMenu cmxd = this.FindResource("rightClickMenu") as ContextMenu;
            cmxd.PlacementTarget = sender as Button;
            cmxd.IsOpen = true;
        }

        private void PlayPause(object sender, RoutedEventArgs e) {
            if (dtClockTime.IsEnabled)
                dtClockTime.Stop();
            else
                dtClockTime.Start();
            
        }

        private void CloseWindow(object sender, RoutedEventArgs e) {
            this.Close();
        }
        
    }
}
