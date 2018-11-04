using System;

namespace Geometry
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(bool isX, int value)
        {
            if (isX)
            {
                x += value;
            }
            else
            {
                y += value;
            }
        }
    }

    struct Line
    {
        public Point beginPoint;
        public Point endPoint;

        public Line(Point beginPoint, Point endPoint)
        {
            this.beginPoint = beginPoint;
            this.endPoint = endPoint;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(beginPoint.x - endPoint.x, 2) + Math.Pow(beginPoint.y - endPoint.y, 2));
        }

    }

    class Program
    {
        public static int AdvancedParse(string label)
        {
            int value;
            while (true)
            {
                Console.Write($"Введите {label}: ");
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }

        }

        static void Main(string[] args)
        {
            int x1 = AdvancedParse("x1");
            int y1 = AdvancedParse("y1");
            int x2 = AdvancedParse("x2");
            int y2 = AdvancedParse("y2");
            var line = new Line(new Point(x1, y1), new Point(x2, y2));
            var isEnd = false;

            while (!isEnd)
            {
                Console.WriteLine("Для получения длины линии нажмите F1\n" +
                    "Для сдвига линии нажмите F2\n" +
                    "Для выхода нажмите Esc");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine($"\nДлина линии равна {line.GetLength()}");
                        break;
                    case ConsoleKey.F2:
                        break;
                    case ConsoleKey.Escape:
                        isEnd = true;
                        break;
                    default:
                        Console.WriteLine("\nНекорректный ввод");
                        break;
                }
            }
        }
    }
}
