using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_Lab2_Wed {
    class MyDataSource : DependencyObject{
        // Singleton pattern (Expose a single shared instance, prevent creating additional instances)
        public static readonly MyDataSource Instance = new MyDataSource();
        private MyDataSource() { }
        // Create a DependencyProperty 'CanSeePhotos'
        public bool IsSelectedXD { get { return (bool)GetValue(IsSelectedXDProperty); } set { SetValue(IsSelectedXDProperty, value); } }
        public static readonly DependencyProperty IsSelectedXDProperty = DependencyProperty.Register("IsSelectedXD", typeof(bool), typeof(MyDataSource), new UIPropertyMetadata());
    }
}
    