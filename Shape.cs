using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace XRay
{
    internal class Shape
    {
        public static string selectedShape = "none";

        public static List<Rectangle> rectangles = new List<Rectangle>();
        public static List<Circle> circles = new List<Circle>();
        
       
        public static Rectangle rect = new Rectangle(0, 0, 0, 0);
        public static Circle circle = new Circle();
        public static Graphics graphics;
        public static Pen pen = new Pen(Color.Red, 1);

        public static void startDrow(int startX, int startY)
        {
            if(Shape.selectedShape == "rectangle")
            {
                Shape.rect.X = startX;
                Shape.rect.Y = startY;
            }
            if (Shape.selectedShape == "circle")
            {
                Circle.x = startX;
                Circle.y = startY;
            }
        }
        public static void endDrow(PictureBox pictureBox, int endX, int endY)
        {
            if (pictureBox.Image != null)
            {
                if (Shape.selectedShape == "rectangle")
                {
                    Shape.drowRectangle(pictureBox, endX, endY);
                }
                if (Shape.selectedShape == "circle")
                {
                    Shape.drowCircle(pictureBox, endX, endY);
                }
            }
        }
        public static void drowRectangle(PictureBox pictureBox, int endX, int endY)
        {
            Shape.rect.Width = Math.Abs(endX - Shape.rect.X);
            Shape.rect.Height = Math.Abs(endY - Shape.rect.Y);

            if (Shape.rect.X > endX) Shape.rect.X = endX;
            if (Shape.rect.Y > endY) Shape.rect.Y = endY;

            Shape.graphics = pictureBox.CreateGraphics();
            Shape.graphics.DrawRectangle(pen, Shape.rect);
            Shape.rectangles.Add(Shape.rect);
        }
        public static void drowCircle(PictureBox pictureBox, int endX, int endY)
        {
            Circle circle = new Circle();
            Shape.graphics = pictureBox.CreateGraphics();
            circle.calculationCircleValue(endX,endY);
            graphics.DrawEllipse(pen, circle.centerX - circle.distance / 2,
                circle.centerY - circle.distance /2 , circle.distance , circle.distance);
            
            Shape.circles.Add(circle);
        }

        public static Bitmap fillCircle(Image image, Circle circle, String type)
        {
            Bitmap bmp = new Bitmap(image);
            if (type == "normal")
                return bmp;
            for (int x = circle.centerX - (circle.distance/2); x < circle.centerX+ (circle.distance/2); x++)
            {
                for (int y = circle.centerY - (circle.distance/2); y < circle.centerY + (circle.distance/2); y++)
                {
                    if(x>=0 && y >= 0 && x <= image.Width && y<= image.Height)
                    {
                        if((x- circle.centerX)*(x - circle.centerX)+(y- circle.centerY)*(y - circle.centerY)<= (circle.distance/2)* (circle.distance/2))
                        {
                            Color pixelColor = bmp.GetPixel(x, y);

                            if (type == "spectrum")
                                bmp.SetPixel(x, y, ColorMap.spectrum(pixelColor));
                            if (type == "hot")
                                bmp.SetPixel(x, y, ColorMap.hot(pixelColor));
                            if (type == "cool")
                                bmp.SetPixel(x, y, ColorMap.cool(pixelColor));
                            if (type == "jet")
                                bmp.SetPixel(x, y, ColorMap.jet(pixelColor));
                            if (type == "rainbow")
                                bmp.SetPixel(x, y, ColorMap.rainbow(pixelColor));
                            if (type == "spring")
                                bmp.SetPixel(x, y, ColorMap.spring(pixelColor));
                        }
                        
                    }

                }
            }

            return bmp;

        }

        public static Bitmap fillRectangle(Image image, Rectangle rect, String type)
        {
            Bitmap bmp = new Bitmap(image);

            if (type == "normal")
                return bmp;

            for (int x = rect.Left; x < rect.Right; x++)
            {
                for (int y = rect.Top; y < rect.Bottom; y++)
                {

                    Color pixelColor = bmp.GetPixel(x, y);

                    if (type == "spectrum")
                        bmp.SetPixel(x, y, ColorMap.spectrum(pixelColor));
                    if (type == "hot")
                        bmp.SetPixel(x, y, ColorMap.hot(pixelColor));
                    if (type == "cool")
                        bmp.SetPixel(x, y, ColorMap.cool(pixelColor));
                    if (type == "jet")
                        bmp.SetPixel(x, y, ColorMap.jet(pixelColor));
                    if (type == "rainbow")
                        bmp.SetPixel(x, y, ColorMap.rainbow(pixelColor));
                    if (type == "spring")
                        bmp.SetPixel(x, y, ColorMap.spring(pixelColor));

                }
            }

            return bmp;
        }
        public static Bitmap cutRectangle(Image image, Rectangle cropArea)
        {
            

            Bitmap bmpImage = new Bitmap(image);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);

        }


    }
}
