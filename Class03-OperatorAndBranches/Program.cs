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
            //编程的三大结构_分支:Switch(开关可以是数值类型,也可以是字符类型)
            string a = Console.ReadLine();
            switch (a)//开关可以是数值类型,也可以是字符类型
            {
                case "1":Console.WriteLine("数字1");break;
                case "a":Console.WriteLine("字母a");break;
                default://默认,其他情况
                    Console.WriteLine("字符未知");break;
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
