using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV.CvEnum;
using System.Drawing;
using System.Drawing.Imaging;
namespace XRay
{
    internal class ImageCompare
    {

        public static string compare(PictureBox pictureBoxCompare1, PictureBox pictureBoxCompare2)
        {
            if (pictureBoxCompare1.Image != null && pictureBoxCompare2.Image != null)
            {
                // Convert PictureBox images to Emgu.CV Image<Bgr, byte>
                Bitmap bitmap1 = new Bitmap(pictureBoxCompare1.Image);
                Bitmap bitmap2 = new Bitmap(pictureBoxCompare2.Image);

                Image<Bgr, byte> image1 = ImageOption.BitmapToImage<Bgr>(bitmap1);
                Image<Bgr, byte> image2 = ImageOption.BitmapToImage<Bgr>(bitmap2);

                // Resize images to the same dimensions
                if (image1.Size != image2.Size)
                {
                    image2 = image2.Resize(image1.Width, image1.Height, Emgu.CV.CvEnum.Inter.Linear);
                }

                // Ensure both images have the same number of channels
                if (image1.NumberOfChannels != image2.NumberOfChannels)
                {
                    image2 = image2.Convert<Bgr, byte>();
                }

                // Use the RadiographComparer to compare the images
                RadiographComparer.ComparisonResult result = RadiographComparer.CompareRadiographs(image1, image2);

                // Display the result
                switch (result)
                {
                    case RadiographComparer.ComparisonResult.NoProgress:
                        return "No significant progress detected.";
                        
                    case RadiographComparer.ComparisonResult.ProgressInTreatment:
                        return "Progress in treatment detected.";
                       
                    case RadiographComparer.ComparisonResult.ProgressionOfDisease:
                        return "Progression of disease detected.";
                       
                }
                return "";
            }
            else
            {
                return "Please upload both images to compare.";
            }
        }
    }
}
