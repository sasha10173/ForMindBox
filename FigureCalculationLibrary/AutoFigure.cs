namespace FigureCalculationLibrary
{
    public class AutoFigure
    {
        public AutoFigure()
        {
            Console.WriteLine("Выбирите тип фигуры у которой хотите узнать площадь.");
            Console.WriteLine("\n Т - Треугольник" +
                "\n К - Круг");

            Console.Write("Ваш выбор: ");

            string choiсe = Console.ReadLine();


            switch (choiсe.ToLower())
            {
                case "т":
                    List<uint> SidesTriangle = new List<uint>();
                    for (int i = 1; i < 4; i++)
                    {
                        Console.Write($"Введите длинну стороны {i}:  ");
                        try
                        {
                            SidesTriangle.Add(Convert.ToUInt32(Console.ReadLine()));
                        }
                        catch (Exception)
                        {
                            throw new Exception("Вы ввели некоректные данные.");
                        }

                        Console.Clear();
                    }

                    var MyTriangle = new Triangle(SidesTriangle[0], SidesTriangle[1], SidesTriangle[2]);
                    MyTriangle.GetArea();

                    break;

                case "к":

                    Console.Write("Введите радиус круга: ");
                    try
                    {
                        uint radius = Convert.ToUInt32(Console.ReadLine());
                        Circle MyCircle = new Circle(radius);
                        MyCircle.GetArea();
                    }
                    catch (Exception)
                    {

                        throw new Exception("Вы ввели некоректные данные");
                    }
                    Console.Clear();

                    break;

                default:
                    Console.WriteLine("Указанной фигуры не найдено.");
                    break;
            }
        }
    }
}
