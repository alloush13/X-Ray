using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRay
{
    internal class ColorMap
    {

        public static Color hot(Color pixelColor)
        {
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            Color color = new Color();
            color = Color.FromArgb(255, intensity, 0);
            return color;
        }
        public static Color jet(Color pixelColor)
        {
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            Color color = new Color();

            if (intensity < 64)

                color = Color.FromArgb(0, 0, 4 * intensity);
            else if (intensity < 128)

                color = Color.FromArgb(0, 4 * (intensity - 64), 255);
            else if (intensity < 192)
                color = Color.FromArgb(4 * (intensity - 128), 255, 255 - 4 * (intensity - 128));
            else
                color = Color.FromArgb(255, 255 - 4 * (intensity - 192), 0);
            return color;


        }

        public static Color cool(Color pixelColor)
        {
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            Color color = new Color();

            color = Color.FromArgb(0, intensity, 255);
            return color;


        }
        public static Color spectrum(Color pixelColor)
        {
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            Color color = new Color();

            int red = (intensity < 85) ? intensity * 3 : (intensity < 170) ? 255 : 255 - 3 * (intensity - 170);
            int green = (intensity < 85) ? 0 : (intensity < 170) ? 3 * (intensity - 85) : 255;
            int blue = (intensity < 85) ? 255 - 3 * intensity : 0;
            color = Color.FromArgb(red, green, blue);
            return color;


        }
        public static Color spring(Color pixelColor)
        {
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            return Color.FromArgb(255, intensity, 255 - intensity);
        }
       

        public static Color rainbow(Color pixelColor)
        {
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            int red, green, blue;

            if (intensity < 43) // Red to Yellow
            {
                red = 255;
                green = 6 * intensity;
                blue = 0;
            }
            else if (intensity < 85) // Yellow to Green
            {
                red = 255 - 6 * (intensity - 43);
                green = 255;
                blue = 0;
            }
            else if (intensity < 128) // Green to Cyan
            {
                red = 0;
                green = 255;
                blue = 6 * (intensity - 85);
            }
            else if (intensity < 170) // Cyan to Blue
            {
                red = 0;
                green = 255 - 6 * (intensity - 128);
                blue = 255;
            }
            else if (intensity < 213) // Blue to Magenta
            {
                red = 6 * (intensity - 170);
                green = 0;
                blue = 255;
            }
            else // Magenta to Red
            {
                red = 255;
                green = 0;
                blue = 255 - 6 * (intensity - 213);
            }

            return Color.FromArgb(red, green, blue);
        }
    }
}
