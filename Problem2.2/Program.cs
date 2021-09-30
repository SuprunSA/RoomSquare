using static System.Console;

namespace Problem2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CountSquare();
        }

        static void CountSquare()
        {
            WriteLine("Введите ширину комнаты: ");
            decimal weight = decimal.Parse(ReadLine());

            WriteLine("Введите длину комнаты: ");
            decimal length = decimal.Parse(ReadLine());

            WriteLine("Введите высоту комнаты: ");
            decimal higth = decimal.Parse(ReadLine());

            WriteLine("Введите количество окон: ");
            int countWindows = int.Parse(ReadLine());
            WriteLine("Введите количество дверей: ");
            int countDoors = int.Parse(ReadLine());
            WriteLine("Площадь стен равна: {0}", CountSquareWithDoorsNWindows(countWindows, countDoors, weight, length, higth));
        }
        static decimal CountSquareWithDoorsNWindows(int a, int b, decimal w, decimal l, decimal h)
        {
            decimal square = 2 * (w * h + l * h) + w * l; // т к нас интересует площадь СТЕН, то пол, предполагаю, не нужно учитывать в площади 
            for (int i = 0; i < a; i++)
            {
                WriteLine("Введите размеры окна №{0}: ", i + 1);
                decimal squareWindow = decimal.Parse(ReadLine()) * decimal.Parse(ReadLine());
                square -= squareWindow;
            }
            for (int i = 0; i < b; i++)
            {
                WriteLine("Введите размеры двери №{0}: ", i + 1);
                decimal squareDoor = decimal.Parse(ReadLine()) * decimal.Parse(ReadLine());
                square -= squareDoor;
            }
            return square;
        }
    }
}
