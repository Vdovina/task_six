using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Формула k-ого члена:   а[к] = а[к–1] + 2 * а[к-2] * а[к–3]\n");
            Console.ResetColor();
            Console.Write("Введите а[1]:   ");
            double a1 = EnterANumber();
            Console.Write("Введите а[2]:   ");
            double a2 = EnterANumber();
            Console.Write("Введите а[3]:   ");
            double a3 = EnterANumber();
            bool ok = false; int n = 0;
            while (!ok)
            {
                Console.Write("Введите N:   ");
                n = EnterAnInteger();
                if (n <= 0) Console.WriteLine("Неоходимо ввести целое число больше 0!");
                else ok = true;
            }
            Console.Write("Введите E:   ");
            double e = EnterANumber();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nНахождение первых ее {n} элементов, таких что |a[k] - a[k-1]| > E.");
            Console.ResetColor();

            int count = 0;
            MakeElement(a1, a2, a3, n, e, count);

            Console.ReadLine();
        }

        public static void MakeElement(double x1, double x2, double x3, int n, double e, int i)
        {
            double x4 = 0;
                if (Math.Abs(x2 - x1) > e && i < n)
                    Console.Write($"{x1}[{i+1}]   ");
                i += 1;

                x4 = x3 + 2 * x2 * x1;
                if (Math.Abs(x3 - x2) > e) MakeElement(x2, x3, x4, n, e, i);
                else return;
        }

        public static double EnterANumber() //ввод числа
        {
            bool ok = false;
            double number = 0;
            do
            {
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите целое число!");
                }
            } while (!ok);
            return number;
        }

        public static int EnterAnInteger() //ввод целого числа
        {
            bool ok = false;
            int number = 0;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите целое число!");
                }
            } while (!ok);
            return number;
        }
    }
}
