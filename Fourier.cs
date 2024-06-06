using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Drawing;
using AForge.Math;

namespace XRay
{
    internal class Fourier
    {
        public static void FourierTransform(PictureBox pictureBoxEnter, PictureBox pictureBoxOuter)
        {
            Bitmap bmp = new Bitmap(pictureBoxEnter.Image);

            Bitmap grayImage = Grayscale.CommonAlgorithms.BT709.Apply(bmp);

            // Create the high-pass filter
            int[,] kernel = {
                    { -1, -1, -1 },
                    { -1,  9, -1 },
                    { -1, -1, -1 }
                };

            Convolution filter = new Convolution(kernel);

            Bitmap hightfilter = filter.Apply(grayImage);

            Bitmap enhancedImage = EnhanceDetails(hightfilter);

            pictureBoxOuter.Image = enhancedImage;
            pictureBoxOuter.Show();

        }

        public static Bitmap EnhanceDetails(Bitmap image)
        {
            // Increase contrast
            ContrastCorrection contrast = new ContrastCorrection(1);
            contrast.ApplyInPlace(image);

            // Adjust brightness
            BrightnessCorrection brightness = new BrightnessCorrection(80);
            brightness.ApplyInPlace(image);

            return image;
        }

       
    }
}
