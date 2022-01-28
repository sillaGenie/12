using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности {0:f2}", Round.Length(r));
            Console.Write("Введите x и y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine( Round.Dots(r,x,y));
        }
    }
    static class Round
    {
        public static double x0=0;
        public static double y0=0;
          public static double Length (double r)
        {
            return 2 * Math.PI * r;
        }
        public static double Area(double r)
        {
            return Math.PI * r*r;
        }
        public static bool Dots(double r, double x,double y)
        {
            double h = (x - x0) * (x - x0) + (y - y0) * (y - y0);
            bool f = false;
            if (h>=r*r)
                f = true;
            return f;
        }



    }
        
}