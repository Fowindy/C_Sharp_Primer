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
            //编程的三大结构:顺序,分支,循环
            //编程的三大结构_分支:Switch
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:Console.WriteLine("数字1");break;
                case 2:Console.WriteLine("数字2");break;
                default://默认,其他情况
                    Console.WriteLine("数字未知");break;
            }
            /*
             * 注意:
             * default可以放在任何位置;
             * 如果case1和case2执行的代码相同,则可以这样写:
             * case1:case2:Console.WriteLine("数字1");break;
             * 每种执行的情况必须加break
             */
            Console.Read();
        }
    }
}
