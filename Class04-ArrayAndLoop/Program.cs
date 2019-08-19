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
            #region 问题6:解决一个数学问题:1/2+2/3+3/4+...+99/100
            double sum = 0;
            for (int i = 1; i <= 99; i++)
            {
                sum += (double)i / (i + 1);//强制转换,类型提升
            }
            Console.WriteLine(sum);
            #endregion
            Console.Read();

        }
    }
}
