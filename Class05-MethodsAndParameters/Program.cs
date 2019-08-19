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

        //形式参数
        static double Average(List<int> nums)//传一个list类型的列表进来
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            return (double)sum / nums.Count;
        }

        //传值传引用的讲解:
        static void Swap(ref int num1,ref int num2)
        {
            int temp;
            temp = num1;num1 = num2;num2 = temp;
        }

        //传值传引用的讲解2:
        static void Add(string str)
        {
            str += "!";
        }

        //传值传引用的讲解3:引用类型加ref和不加ref基本无区别,值类型加ref和不加ref区别很大
        //out返回添加成功与否
        static void Add(List<int> list,out bool success)
        {
            list.Add(2);
            success = true;
        }
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);

            //调用方法参数的名称和方法命名的参数的名称可以不一致
            //实际参数
            Console.WriteLine("list列表的平均值为:{0}",Average(list));//2.75

            int a = 1;
            int b = 2;
            Swap(ref a, ref b);//交换成功//传引用:不再是复制关系,而是公用关系;指向了相同的内存地址,对相同的内存地址进行修改
            Console.WriteLine("a={0},b={1}", a, b);

            string str = "123";
            Add(str);
            Console.WriteLine(str);//123//string虽是引用类型,但有字符串的不变特性,甚至可以粗暴的把string归结到值类型

            bool j = false;
            var lists = new List<int>();
            lists.Add(1);
            Add(lists,out j);
            if (j)
            {
                Console.WriteLine("添加成功");
            }
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
            //引用类型加ref和不加ref无区别
            //值类型加ref和不加ref区别很大

            //为什么要使用out参数?函数理论上最多只能返回一个值,当需要返回多个值时使用out参数
            int i;
            int.TryParse("1", out i);
            Console.Read();
        }
    }
}
