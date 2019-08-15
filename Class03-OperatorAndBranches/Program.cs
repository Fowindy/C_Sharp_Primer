using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03_OperatorAndBranches
{
    class Program
    {
        static void Main(string[] args)
        {
            //二元运算符的优先级:()>(*,/,%)>(+,-)>(=,++,--,+=,-=,%=,/=)
            //1+2*3 = 7     (1+2)*3 = 9

            //字符串的"+":连接符
            string str1 = "ABC";
            string str2 = "EFG";
            Console.WriteLine(str1 + str2);//ABCEFG
            Console.Read();
        }
    }
}
