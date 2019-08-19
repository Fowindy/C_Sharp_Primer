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
        /*
         * 例子3:求平均值
         * 理解参数:
         * $参数的名字可以不一致
         * $传值,传引用ref,out参数
         */

        static double Average(List<int> list)//传一个list类型的列表进来
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return (double)sum / list.Count;
        }
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);

            Console.WriteLine("list列表的平均值为:{0}",Average(list));//2.75
            Console.Read();
        }
    }
}
