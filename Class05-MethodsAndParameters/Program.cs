using Class05_MethodsAndParameters2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_MethodsAndParameters
{
    class Program
    {
        //例子7-1:再论斐波那契数列_递归实现
        static long Fibonacci(long n)
        {
            if (n == 1 || n == 2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.Read();
        }
    }
}
