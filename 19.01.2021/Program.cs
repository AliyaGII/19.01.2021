using System;

namespace _19._01._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задача № 1

            double a = 16.8;
            double b = 12.4;
            double result = Math.Round(Math.Sqrt(a * b), 2);

            Console.WriteLine(" a " + "=" + a);
            Console.WriteLine(" b " + "=" + b);
            Console.WriteLine(" Ответ " + " : " + result + "\n");


            // Задача № 2

            double A = 1.40;
            double B = -5.50;
            double C = 0.60;

            double AC = Math.Round(Math.Abs(A - C), 2);
            double BC = Math.Round(Math.Abs(B - C), 2);
            double SUM = Math.Round(AC + BC, 2);

            Console.WriteLine(" A " + " = " + A);
            Console.WriteLine(" B " + " = " + B);
            Console.WriteLine(" C " + " = " + C);
            Console.WriteLine(" AC " + " = " + AC);
            Console.WriteLine(" BC " + " = " + BC);
            Console.WriteLine(" AC + BC " + " = " + SUM + "\n");


            //Задача № 3

            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;

            double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine($"x1, y1 : {x1}; {y1}");
            Console.WriteLine($"x2, y2 : {x2}; {y2}");
            Console.WriteLine("Результат : " + Math.Round(res, 2) + "\n");

            //Задача №4

            int Q = 42;
            int l = Q % 10;
            int h = Q / 10;

            Console.WriteLine("Число : " + Q);
            Console.WriteLine("Результат : " + l + h + "\n");



            //Задача №5

            int N = 10985;
            int M = N / 60;

            Console.WriteLine("N : " + N);
            Console.WriteLine("Результат : " + M + "\n");



            //Задача № 6  

            int day = 123;
            int n = day % 7;

            Console.WriteLine("Номер дня недели : " + n);
            Console.WriteLine("K = " + day);
        }
    }
}
