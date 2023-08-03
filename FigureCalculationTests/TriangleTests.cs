using FigureCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculationTests
{
    public class TriangleTests
    {
        [Test]
        public void GetSpaceTriangleTest()
        {
            double a = 5;
            double b = 4;
            double c = 8;

            double expected = 8.181534085976786;

            Triangle MyTriangle = new Triangle(a, b, c);
            var result = MyTriangle.GetArea();

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void GetPerimeterTest()
        {
            double a = 5;
            double b = 4;
            double c = 8;

            double expected = 17;

            Triangle myTriangle = new Triangle(a, b, c); 
            var result = myTriangle.GetPerimeter();

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void RightTriangleCheckTest()
        {
            double a = 25;
            double b = 24;
            double c = 7;

            bool expected = true;

            Triangle MyTriangle = new Triangle(a, b, c);
            var result = MyTriangle.RightTriangleCheck();

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
