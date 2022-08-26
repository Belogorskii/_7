/*Два треугольника заданы длинами своих сторон. Определить, 
площадь какого из них больше (создать метод для вычисления  
площади  треугольника по длинам его сторон).  Для решения 
задачи можно использовать формулу Герона, 
где x, y, z – стороны треугольника, p – полупериметр.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            double s = Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника 1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double p1;
            double s1 = GetSquare(a1, b1, c1);
            Console.WriteLine("Введите стороны треугольника 2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double p2;
            double s2 = GetSquare(a2, b2, c2);
            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника.");
            else
            if (s1 < s2)
                Console.WriteLine("Площадь первого треугольника меньше площади второго треугольника.");
            else
            if (s1 == s2)
                Console.WriteLine("Площадь первого треугольника равна площади второго треугольника");
            Console.ReadKey();
        }
    }
}