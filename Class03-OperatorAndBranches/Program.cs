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
            //条件运算符(三元操作符)(使用条件运算符:三个数字中最大的):
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("最大的数字是:{0}",((c > (a > b ? a : b))) ? c : (a > b ? a : b));
            //等价于:
            Console.WriteLine("最大的数字是:{0}", a > b ? (a > c ? a : c) : (b > c ? b : c));
            /*
             * 关系表达式(二元操作符):
             * >(大于),<(小于),小于等于(<=),大于等于(>=),==(等于等于),!=(不等于)
             * 
             * 逻辑运算符(二元操作符):
             * ||(或):同假则假
             * &&(且):同真则真
             * 
             * 逻辑求反:!(一元操作符,优先级高于二元)
             * 
             * 条件运算符(三元操作符):
             * 布尔表达式?A:B;
             */
            Console.Read();
        }
    }
}
