using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_project
{
    public class Point
    {
        public double x, y;//обьявить поля класса

        public static double distanceBetween (double ax, double ay, double bx, double by)
        {
            double result;
            double dx = bx - ax;
            double dy = by - ay;
            result = Math.Sqrt(dx * dx + dy * dy);
            return result;


        }
        public static double distanceBetween (Point a, Point b)
        {
            double result;
            double dx = b.x - a.x;
            double dy = b.y - a.y;
            result = Math.Sqrt(dx * dx + dy * dy);
            return result;
        }
        public static Point zero()
        {
            Point instance = new Point();
            instance.x = 0;
            instance.y= 0;

            return instance;

        }
        public static Point make(double px, double py)
        {
            Point instance = new Point();
            instance.x = px;
            instance.y = py;

            return instance;
        }
    }
}
