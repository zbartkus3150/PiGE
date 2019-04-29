using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wpf_Lab2_Wed {
    public class ImgInfo {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Size { get; set; }
        public string FullPath { get; set; }
        public static bool IsSelected { get; set; }

        public ImgInfo(string name, double width, double height, double size) {
            Name = name;
            Width = (int)width;
            Height = (int)height;
            Size = Math.Round(size / 1024d, 2);
        }
    }

}
