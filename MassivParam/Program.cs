using System;

namespace MassivParam
{
    public delegate int masElem();
    public delegate int Delegate(masElem[] mas);
    class Program
    {
        const int n = 5;
        private static int Method1(masElem[] mas)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = new masElem(Method);
                sum += mas[i].Invoke();
            }
            return sum/n;
        }
        private static int Method()
         { Random rm = new Random();
            int num= rm.Next(1, 101);
            Console.WriteLine(num);
            return num;
         }
            
    
       static void Main(string[] args)
        {
            masElem[] mas = new masElem[n];
            Delegate sum = new Delegate(Method1);
            Console.WriteLine("Average:" + sum(mas));
        }
    }
} 
