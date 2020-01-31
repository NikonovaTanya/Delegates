using System;

namespace calc
{
    public delegate int Delegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Delegate Add;
            Delegate Sub;
            Delegate Mul;
            Delegate Div;

            Add = (a, b) => { return a + b; };
            Sub = (a, b) => { return a - b; };
            Mul = (a, b) => { return a * b; };
            Div = (a, b) => { if (b != 0) return a / b; else return -100000; };
            string ch="0";
            Console.Write("Введите а=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b=");
            int b = int.Parse(Console.ReadLine());
            do { 
            Console.WriteLine("Введите арифметическое действие + - * /");
            ch = Console.ReadLine();
            switch (ch)
            {
                case "+":
                    {
                        Console.WriteLine("{0} + {1} = {2}",a,b, Add(a, b)); 
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("{0} - {1} = {2}", a, b, Sub(a, b));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("{0} * {1} = {2}", a, b, Mul(a, b));
                        break;
                    }
                case "/":
                    { if (Div(a, b)!=-100000)
                        Console.WriteLine("{0} / {1} = {2}", a, b, Div(a, b));
                     else
                        Console.WriteLine("Деление на ноль");
                    break;
                    }

                default:
                    {
                        Console.WriteLine("Неверный ввод!");
                        break;

                    }
            }
            Console.WriteLine("0-выход из программы!  ");
            ch = Console.ReadLine();
            Console.WriteLine();
        } while (ch != "0");

        }
    }
}
