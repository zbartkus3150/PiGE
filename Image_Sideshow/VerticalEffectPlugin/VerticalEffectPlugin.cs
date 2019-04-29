using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace VerticalEffectPlugin
{
    public class VerticalEffectPlugin : ISlideshowEffect.ISlideshowEffect {
        public string Name {
            get { return "Vertical Effect"; }
        }
        public void PlaySlideshow(Image imageIn, Image imageOut, double windowWidth, double windowHeight) {
            Storyboard mystoryboard;
            Storyboard mystoryboard2;
            imageIn.VerticalAlignment = VerticalAlignment.Bottom;
            imageOut.VerticalAlignment = VerticalAlignment.Top;
            mystoryboard = new Storyboard();
            mystoryboard2 = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation(0.0, windowHeight, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animation, new PropertyPath(FrameworkElement.HeightProperty));
            Storyboard.SetTarget(animation, imageIn);
            DoubleAnimation animation2 = new DoubleAnimation(windowHeight, 0.0, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animation2, new PropertyPath(FrameworkElement.HeightProperty));
            Storyboard.SetTarget(animation2, imageOut);
            mystoryboard.Children.Add(animation);
            mystoryboard2.Children.Add(animation2);
            mystoryboard.Begin();
            mystoryboard2.Begin();
        }
    }
}
