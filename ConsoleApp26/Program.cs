using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    

   internal class Program
    {
        
        static double AreaOfTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;
        }

        static void Main()
        {
            
            Console.WriteLine("Введите координаты вершин пятиугольника:");

            Console.Write("x1, y1: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2, y2: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("x3, y3: ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            Console.Write("x4, y4: ");
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            Console.Write("x5, y5: ");
            double x5 = double.Parse(Console.ReadLine());
            double y5 = double.Parse(Console.ReadLine());

         

            double area1 = AreaOfTriangle(x1, y1, x2, y2, x3, y3);
            double area2 = AreaOfTriangle(x1, y1, x3, y3, x4, y4);
            double area3 = AreaOfTriangle(x1, y1, x4, y4, x5, y5);

            // Общая площадь пятиугольника
            double totalArea = area1 + area2 + area3;

            // Выводим результат
            Console.WriteLine("Площадь пятиугольника: " + totalArea);
            Console.ReadKey();
        }
    }
}


