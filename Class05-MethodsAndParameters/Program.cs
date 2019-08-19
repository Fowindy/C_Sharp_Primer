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
        //例子4:继续交换案例_重载:函数名可以相同,但是参数不能完全一样
        static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;a = b;b = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.WriteLine("a={0},b={1}",a,b);//a=2,b=1
            Console.Read();
        }
    }
}
