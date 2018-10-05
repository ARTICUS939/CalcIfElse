using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действие:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Ответ: " + total);
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Ответ: " + total);
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Ответ: " + total);
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Ответ: " + total);
            }

            Console.ReadLine();

        }
    }
}
