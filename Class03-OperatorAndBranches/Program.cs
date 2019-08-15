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
            //编程的三大结构_分支:(if switch)(if三种情况:含嵌套if)
            int a = int.Parse(Console.ReadLine());
            if (a > 10)
            {
                Console.WriteLine("a大于10");
            }
            else
            {
                #region 嵌套if
                if (a == 10)
                {
                    Console.WriteLine("a等于10");
                }
                else
                {
                    Console.WriteLine("a小于10");
                } 
                #endregion
            }
            Console.Read();
        }
    }
}
