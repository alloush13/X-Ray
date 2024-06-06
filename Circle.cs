using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRay
{
    internal class Circle
    {
        public static int x =0;
        public static int y =0;
        public  int distance = 0;
        public  int centerX =0;
        public  int centerY =0;


        public  void calculationCircleValue(int endX,int endY)
        {
            this.centerX = (Circle.x + endX) / 2;
            this.centerY = (Circle.y + endY) / 2;
            this.distance = (int) Math.Sqrt((double)((endX - Circle.x) * (endX - Circle.x)) + ((endY - Circle.y) * (endY - Circle.y)));
        }


    }
}
