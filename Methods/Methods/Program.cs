using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int sum = sum();
            //Console.WriteLine(Sum());

            Sum();
            int first = 7;
            int second = 10;
            Console.WriteLine(Multiply(first, second));
            DisplayNumbers((100));

        }

        static void Sum()
        {
            int a = 2;
            int b = 3;

            int sum = a + b;
            Console.WriteLine(sum);
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void DisplayNumbers(int n)
        {
            for (int 1=1; int<=n; int++)
            {

            }



        }

    }
}
