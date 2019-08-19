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
            #region list集合
            var nums = new List<int>();//list集合实例化
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            //对list集合进行正序排列
            nums.Sort();

            //输出正序排列之后的结果:
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            //对list集合查最大值,最小值,平均值
            Console.WriteLine("集合中的最大值是:{0},最小值是:{1},平均值是:{2}", nums.Max(), nums.Min(), nums.Average());

            #endregion
            Console.Read();
        }
    }
}
