using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_ArrayAndLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 为什么使用数组(举例:斐波那契数列_使用数组循环实现)
            /*
            * 为什么使用数组?
            * 
            * 举个例子:斐波那契数列
            * 1 1 2 3 5 8 13......
            */
            int[] a = new int[11];
            a[1] = 1;
            a[2] = 1;

            int i = 3;
            while (i != 11)
            {
                a[i] = a[i - 1] + a[i - 2];
                i++;
            }

            int j = 1;
            while (j != 11)
            {
                Console.WriteLine(a[j]);
                j++;
            }

            Console.Read();
            #endregion
        }
    }
}
