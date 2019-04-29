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
using Microsoft.Win32;

namespace Wpf_Lab2_Wed {
    class myTreeItem : TreeViewItem {
        public string FilePath { get; set; }

        public myTreeItem(string fp) : base() {
            FilePath = fp;
        }
    }

}
