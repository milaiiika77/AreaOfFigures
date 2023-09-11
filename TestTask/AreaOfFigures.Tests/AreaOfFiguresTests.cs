using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaOfFigures.Tests
{
    [TestClass]
    public class AreaOfFiguresTests
    {
        [TestMethod]
        public void CircleArea_10_314returned()
        {
            double radius = 10;
            string expected = "314,159265358979";

            double actual = Area.CircleArea(radius);
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void TriangleArea_4and3and5_6returned()
        {
            double a = 4;
            double b = 3;
            double c = 5;
            string expected = "Ответ: 6. Треугольник прямоугольный";

            string actual = Area.TriangleArea(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_8and13and8_30returned()
        {
            double a = 8;
            double b = 13;
            double c = 8;
            string expected = "Ответ: 30,3139819225386. Треугольник не прямоугольный";
            string actual = Area.TriangleArea(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
