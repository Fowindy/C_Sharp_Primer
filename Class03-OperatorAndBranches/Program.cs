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
            //空结合运算符(二元操作符):(一般用于默认路径,有新路径则用新的,没有新的则用默认的)
            string fileName = null;
            fileName = fileName ?? "default.txt";
            Console.WriteLine(fileName);
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
             * 
             * 空结合运算符(二元操作符):
             * 表达式1??表达式2   //表达式1是否为null,如果为null就使用表达式2的结果作为表达式1的默认值
             * 
             * 按位与运算符(不讲)
             */
            Console.Read();
        }
    }
}
