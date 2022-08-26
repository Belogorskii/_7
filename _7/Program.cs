/*Создать метод для вычисления объема и площади поверхности куба по длине его ребра.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double GetSquare(double a)
        {
            return 6.0 * a * a;
        }
        static double GetVoi(double a)
        {
            return a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрта");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            s = GetSquare(a);
            v = GetVoi(a);
            Console.WriteLine("Площадь поверхности куба = {0}", s);
            Console.WriteLine("Объем куба = {0}", v);
            Console.ReadKey();
        }
    }
}