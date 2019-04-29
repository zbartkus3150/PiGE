using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace OpacityEffectPlugin
{
    public class OpacityEffectPlugin : ISlideshowEffect.ISlideshowEffect {
        public string Name {
            get { return "Opacity Effect"; }
        }
        public void PlaySlideshow(Image imageIn, Image imageOut, double windowWidth, double windowHeight) {
            Storyboard mystoryboard = new Storyboard();
            Storyboard mystoryboard2 = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation(0.0, 1.0, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animation, new PropertyPath(UIElement.OpacityProperty));
            Storyboard.SetTarget(animation, imageIn);
            DoubleAnimation animation2 = new DoubleAnimation(1.0, 0.0, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animation2, new PropertyPath(UIElement.OpacityProperty));
            Storyboard.SetTarget(animation2, imageOut);
            mystoryboard2 = new Storyboard();
            mystoryboard.Children.Add(animation);
            mystoryboard2.Children.Add(animation2);
            mystoryboard.Begin();
            mystoryboard2.Begin();
        }
    }
}
