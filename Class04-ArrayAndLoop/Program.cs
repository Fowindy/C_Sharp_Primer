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
            #region 为什么使用数组(举例:斐波那契数列_使用数组+Foreach循环缺点是,必须是全部,管控不了起点,不建议使用_终点自定义)
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

            foreach (var item in a)//缺点是,必须是全部,管控不了起点
            {
                Console.WriteLine(item);
            }



            #endregion

            #region 问题1:如何生成一堆随机数(0-9)_取余方式
            var r = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = r.Next(0,51);
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 问题2:求数列的和
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
            #endregion

            #region 问题3:求数组中最大的数
            int max = a[0];
            for (int i = 0; i < N; i++)
            {
                if (a[i] >= max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
            #endregion

            #region 问题4:查找数组中某一个数是否存在
            int num = 50;
            for (int i = 0; i < N; i++)
            {
                if (a[i] == num)
                {
                    Console.WriteLine("{0}这个数存在",num);
                    break;
                }
                if (i == N - 1 && a[i] != num)
                {
                    Console.WriteLine("{0}这个数不存在",num);
                }
            }
            Console.Read();
            #endregion
        }
    }
}
