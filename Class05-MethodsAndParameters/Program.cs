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
        //例子5:还是交换案例_泛型:一种函数处理多种类型的功能
        static void Swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;a = b;b = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);//整型可以交换//完整写法Swap<int>(ref a, ref b);
            Console.WriteLine("a={0},b={1}",a,b);//a=2,b=1

            string str1 = "123";
            string str2 = "abc";
            Swap(ref str1, ref str2);//字符类型也可以完成交换//完整写法Swap<string>(ref str1, ref str2);
            Console.WriteLine("str1={0},str2={1}", str1, str2);//str1=abc,str2=123

            Console.Read();
        }
    }
}
