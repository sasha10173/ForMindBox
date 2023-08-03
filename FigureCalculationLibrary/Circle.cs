namespace FigureCalculationLibrary
{
    public class Circle : Figure
    {
        public Circle(double radiusCircle)
        {
            A = radiusCircle;
        }

        public override double GetArea()
        {
            return Pi * (A * A);
        }

        public override double GetPerimeter()
        {
            return 2 * Pi * A;
        }

    }
}
