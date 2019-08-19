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
        //例子1:写一个什么都不做的函数(方法),方法是在类里面
        //无static为动态方法
        void Test() { }
        //有static为静态方法,无static叫动态方法;静态方法无法调用动态方法
        //动态方法既可以调用动态方法也可以调用静态方法;
        //静态方法只能调用静态方法;
        static void Main(string[] args)
        {
            /*
             * 方法是什么?
             * 首先看看方法涉及的基本元素:
             * System.Console.Write("name");
             * 命名空间  类     方法  参数
             * 
             * 为什么使用方法?
             * 让程序简单明了,模块化,功能更内聚,将重复的逻辑放在一起
             */

            //例子1:写一个什么都不做的函数
            //理解 方法名 书写方法

            //快捷键:ctrl + tab 切换工程
            //快捷键:alt + tab 切换任务
            Class1.Func();

            Console.Read();
        }
    }
}
