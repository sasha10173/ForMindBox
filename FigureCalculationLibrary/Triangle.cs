namespace FigureCalculationLibrary
{
    public class Triangle : Figure
    {

        public Triangle(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }


        public override double GetArea()
        {
            double SemiPerimeter = (A + B + C) / 2;

            double Foo = SemiPerimeter * (SemiPerimeter - A) * (SemiPerimeter - B) * (SemiPerimeter - C);

            double AreaTriangle = Math.Sqrt(Foo);
            if (double.IsNaN(AreaTriangle))
            {
                throw new Exception("Такого треугольника не существует.");
            }

            return AreaTriangle;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Метод проверяющий является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool RightTriangleCheck()
        {
            double[] triangleArray = new double[] { A, B, C };
            double MaxValue = triangleArray.Max();
            double MinValue = triangleArray.Min();
            double MidlValue = triangleArray.Where(x => x > triangleArray.Min() && x < triangleArray.Max()).Sum();


            if (MaxValue * MaxValue == MidlValue * MidlValue + MinValue * MinValue)
            {
                return true;
            }
            return false;
        }
    }
}
