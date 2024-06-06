using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.Drawing.Imaging;

namespace XRay
{
    internal class ImageOption
    {
        public static void upload(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open X-ray Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = new Bitmap(Image.FromFile(openFileDialog.FileName));
                 
                    pictureBox.Image = ImageOption.resizeImage(image);
                    pictureBox.Width= pictureBox.Image.Width;
                    pictureBox.Height = pictureBox.Image.Height;
                    pictureBox.Show();
                    
                    Shape.rectangles.Clear();
                }
            }
        }
        public static Image resizeImage(Image imgToResize)
        {
            float ratio = ImageOption.ratioImage(imgToResize);
            return (Image)(new Bitmap(imgToResize, new Size(300, (int)(300.0f * ratio))));

        }
        public static float ratioImage(Image image)
        {
            float ratio =0.00f;
            if (image.Width > 0) ratio = (float)image.Height / (float)image.Width;
            if (ratio > 1.4f) ratio = 1.4f;

            return ratio;
        }

        

        public static void ConvertImageColor(PictureBox pictureBoxEnter, PictureBox pictureBoxOuter, String type)
        {
            Bitmap bmp = new Bitmap(pictureBoxEnter.Image);

            for (int i = 0; i < Shape.rectangles.Count; i++)
            {
                bmp = Shape.fillRectangle(bmp, Shape.rectangles[i], type);
            }
            for (int i = 0; i < Shape.circles.Count; i++)
            {
                bmp = Shape.fillCircle(bmp, Shape.circles[i], type);
            }
            pictureBoxOuter.Image = bmp;
            pictureBoxOuter.Show();
            
        }

        public static void addTextOnImage(PictureBox pictureBoxOuter,TextBox note)
        {

            Bitmap image =(Bitmap) pictureBoxOuter.Image;

            using (Graphics graphics = Graphics.FromImage(image))
            {
                using (Font arialFont = new Font("Arial", 15))
                {
                    graphics.DrawString(note.Text, arialFont, Brushes.Red, note.Location);
                }
            }
            pictureBoxOuter.Image = image;

        }
        public static void updateNoteLocation( Point location, TextBox note, Button saveNote)
        {
            note.Location = location;
            saveNote.Location = new Point(location.X, location.Y + 20);

        }

        public static Image<TColor, byte> BitmapToImage<TColor>(Bitmap bitmap)
            where TColor : struct, IColor
        {
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);

            Image<TColor, byte> image = new Image<TColor, byte>(bitmap.Width, bitmap.Height, bitmapData.Stride,bitmapData.Scan0);

            bitmap.UnlockBits(bitmapData);
            return image;
        }

    }
}
