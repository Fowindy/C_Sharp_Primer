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
        //例子6:累加案例_参数数量可变
        /*
         * $理解:参数数量可变参数也可以加入模板
         */
        static int Sum(params int[] nums)
        {
            return nums.Sum();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6));//21
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6,7,8,9));//45
            Console.Read();
        }
    }
}
