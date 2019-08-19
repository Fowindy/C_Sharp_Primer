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
        //例子6:累加案例_参数数量可变_加入模板
        /*
         * $理解:参数数量可变参数也可以加入模板
         */

        //自己实现:泛型模板+可变参数+约束实现任意数值累加,代码的健壮性非常强
        //可变参数必须是形参中的最后一个参数
        static T Sum<T>(string a, params T[] nums) where T : struct//约束:数值类型
        {
            double sum = 0;
            foreach (var item in nums)
                sum += Double.Parse(item.ToString());
            return (T)Convert.ChangeType(sum, typeof(T));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum("a", 1, 2, 3, 4, 5, 6));//21
            Console.WriteLine(Sum("b", 2, 3, 4, 5, 6, 7, 8, 9));//44
            Console.WriteLine(Sum("c", 2.7, 3.9, 4, 5, 6, 7, 8.7, 9));//46.3
            Console.Read();
        }
    }
}
