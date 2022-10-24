using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_project;

namespace Testing_Project
{
    [TestClass]

    public class PointSuite
    {
        [TestMethod]
        public void distanceBetweenValuesTest()
        {
            double actual = Point.distanceBetween(1, 1, 3, 4);
            Assert.AreEqual(3.6056, actual, 0.0001);

        }

        [TestMethod]
        public void distanceBetweenPointsTest()
        {
            Point src, dest;// обьявление переменной
            src = new Point();//инициализация
            dest = new Point();

            src.x = 1;
            src.y = 1;
            dest.x = 3;
            dest.y = 4;

            double actual = Point.distanceBetween(src,dest);
            Assert.AreEqual(3.6056, actual, 0.0001);


            src.x = -2;
            src.y = 4;
            dest.x = 8;
            dest.y = -10;

            double actual1 = Point.distanceBetween(src, dest);
            Assert.AreEqual(17.2046, actual1, 0.0001);

         
            src = Point.zero();
            dest.x = -5;
            dest.y = -7;

            double actual3 = Point.distanceBetween(src, dest);
            Assert.AreEqual(8.6023, actual3, 0.0001);

            src = Point.zero();
            dest= Point.zero();

            double actual2 = Point.distanceBetween(src, dest);
            Assert.AreEqual(0, actual2, 0.0001);

            src = Point.zero();
            dest = Point.make(-5, -7);

            double actual4 = Point.distanceBetween(src, dest);
            Assert.AreEqual(8.6023, actual4, 0.0001);

        }

        
    }
}
