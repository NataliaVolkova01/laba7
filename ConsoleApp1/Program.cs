﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char z;
            Console.WriteLine("Введите a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действие (+, -, *, /) ");
            z = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите b ");
            b = Convert.ToDouble(Console.ReadLine());
            switch (z)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("деление на ноль недопустимо");
                    else
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadLine();
        }
    }
}
