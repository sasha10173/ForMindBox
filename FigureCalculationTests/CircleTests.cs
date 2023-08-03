
using FigureCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculationTests
{
    public class CircleTests
    {
        [Test]
        public void GetAreaTest()
        {
            double a = 15;

            double expected = 706.5;

            Circle spaceCircle = new Circle(a);
            var result = spaceCircle.GetArea();

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetPerimeterTest()
        {
            double a = 15;

            double expected = Math.Round(94.2, 1);
;

            Circle spaceCircle = new Circle(a);
            var result = Math.Round(spaceCircle.GetPerimeter(), 1);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
