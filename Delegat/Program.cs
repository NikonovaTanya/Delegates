using System;

namespace Delegat
{
    class Program
    {
        public delegate double Delegate(int a, int b, int c);
        static void Main(string[] args)
        {
            Delegate d = delegate (int a, int b, int c) { return (a + b + c)/3.0; };
            Console.WriteLine("({0}+ {1}+ {2})/3 = {3}", 1,2,2, d(1, 2, 2));  
                    
        }
    }
}
