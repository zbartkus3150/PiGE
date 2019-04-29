using System.Windows.Controls;

namespace ISlideshowEffect
{
    public interface ISlideshowEffect {
        string Name { get; }
        void PlaySlideshow(Image imageIn, Image imageOut, double windowWidth, double windowHeight);
    }
}
