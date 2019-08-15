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
            //编程的三大结构_分支:(else只跟最近的if:嵌套简写---多分支)
            int a = int.Parse(Console.ReadLine());
            if (a > 10)
                Console.WriteLine("a大于10");
            else if (a == 10)
                Console.WriteLine("a等于10");
            else
                Console.WriteLine("a小于10");
            Console.Read();
        }
    }
}
