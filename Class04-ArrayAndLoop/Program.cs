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
            #region 为什么使用数组(举例:斐波那契数列_使用数组+For循环实现_终点自定义)
            /*
            * 为什么使用数组?
            * 
            * 举个例子:斐波那契数列
            * 1 1 2 3 5 8 13......
            */
            const int N = 38;
            int[] a = new int[N];
            a[1] = 1;
            a[2] = 1;

            for (int i = 3; i < N; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }

            for (int i = 1; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.Read();
            #endregion
        }
    }
}
