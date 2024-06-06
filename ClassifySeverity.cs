using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
namespace XRay
{
    internal class ClassifySeverity
    {
        public static string apply(Image<Bgr, byte> image)
        {
            // Convert the image to grayscale
            Image<Gray, byte> grayImage = image.Convert<Gray, byte>();

            // Compute GLCM in multiple directions
            Matrix<float> glcm0 = ComputeGLCM(grayImage, 0);
            Matrix<float> glcm45 = ComputeGLCM(grayImage, 45);
            Matrix<float> glcm90 = ComputeGLCM(grayImage, 90);
            Matrix<float> glcm135 = ComputeGLCM(grayImage, 135);

            // Average the GLCMs
            Matrix<float> glcm = (glcm0 + glcm45 + glcm90 + glcm135) / 4;

            // Normalize GLCM
            glcm /= CvInvoke.Sum(glcm).V0;

            // Calculate contrast, correlation, energy, and homogeneity
            double contrast = 0;
            double correlation = 0;
            double energy = 0;
            double homogeneity = 0;
            double meanX = 0;
            double meanY = 0;
            double stdDevX = 0;
            double stdDevY = 0;

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    double value = glcm[i, j];
                    contrast += value * Math.Pow(i - j, 2);
                    energy += value * value;
                    homogeneity += value / (1 + Math.Abs(i - j));
                    meanX += i * value;
                    meanY += j * value;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    double value = glcm[i, j];
                    stdDevX += Math.Pow(i - meanX, 2) * value;
                    stdDevY += Math.Pow(j - meanY, 2) * value;
                }
            }

            stdDevX = Math.Sqrt(stdDevX);
            stdDevY = Math.Sqrt(stdDevY);

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    double value = glcm[i, j];
                    correlation += ((i - meanX) * (j - meanY) * value) / (stdDevX * stdDevY);
                }
            }

            // Log the calculated features
            Console.WriteLine($"Contrast: {contrast}, Energy: {energy}, Homogeneity: {homogeneity}, Correlation: {correlation}");

            // Define thresholds for classification based on GLCM features
            if (contrast > 800 || (energy < 0.001 && homogeneity < 0.2))
            {
                return "Severe";
            }
            else if (contrast > 500 || (energy < 0.005 && homogeneity < 0.3))
            {
                return "Moderate";
            }
            else
            {
                return "Mild";
            }
        }

        public static Matrix<float> ComputeGLCM(Image<Gray, byte> grayImage, int angle)
        {
            Matrix<float> glcm = new Matrix<float>(256, 256);
            int dx = 0, dy = 0;

            switch (angle)
            {
                case 0:
                    dx = 1;
                    dy = 0;
                    break;
                case 45:
                    dx = 1;
                    dy = -1;
                    break;
                case 90:
                    dx = 0;
                    dy = -1;
                    break;
                case 135:
                    dx = -1;
                    dy = -1;
                    break;
            }

            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    int newX = x + dx;
                    int newY = y + dy;

                    // Ensure the new indices are within bounds
                    if (newX >= 0 && newX < grayImage.Width && newY >= 0 && newY < grayImage.Height)
                    {
                        byte currentPixel = grayImage.Data[y, x, 0];
                        byte nextPixel = grayImage.Data[newY, newX, 0];
                        glcm[currentPixel, nextPixel]++;
                    }
                }
            }

            return glcm;
        }
    }
}
