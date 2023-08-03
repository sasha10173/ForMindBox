namespace FigureCalculationLibrary
{
    abstract public class Figure
    {
        protected const double Pi = 3.14;
        protected double A;
        protected double B;
        protected double C;
        protected double D;
        protected double E;
        protected double F;

        /// <summary>
        /// Метод возвращает площадь фигуры.
        /// </summary>
        /// <returns></returns>
        virtual public double GetArea()
        {
            return double.NaN;
        }

        /// <summary>
        /// Метод возвращает периметр фигуры.
        /// </summary>
        /// <returns></returns>
        virtual public double GetPerimeter()
        {
            return double.NaN;
        }
    }
}
