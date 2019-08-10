using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01_TutorialLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C#基础
             * WinForm
             * ASP.NET
             */

            //用记事本写一个控制台运行程序,在控制台输出"这是我的第一个C#程序"
            /*
             * 1.首先找到csc.exe文件
             * 2.在系统环境变量path中添加该csc.exe文件所在的地址;
             * 3.在控制台输入csc.exe验证系统环境是否配置成功;
             * 4.用记事本新建一个HelloWorld.cs的文件并保存;
             * 5.文件内容为:
             * class HelloWorld
             * {
             *      static void Main()
             *      {
             *          System.Console.WriteLine("这是我的第一个C#程序");
             *      }
             * }
             * 6.在控制台用cd空格加HelloWorld.cs的地址;
             * 7.用1.cs的盘符如d:,切换到HelloWorld.cs的目录;
             * 8.csc.exe HelloWorld.cs回车,在HelloWorld.cs的目录下会编译生成HelloWorld.exe文件;
             * 9.在控制台输入HelloWorld回车,便成功运行显示"这是我的第一个C#程序";
             */
            
            //局部变量:只能在与之对应的代码块中使用(代码块:包围此变量的大括号内的内容)
            string message1;
            string message2;
            string str1, str2 = "qwe";//变量声明的时候最好初始化赋值,如果没有初始化赋值,后面又没有赋值的话,程序会报错;
            str1 = "abc";
            System.Console.WriteLine(str1);

            //变量值的覆盖
            str1 = "123";
            System.Console.WriteLine(str1);

            System.Console.WriteLine(str2);
            message1 = "这是我的第一个C#程序";
            message2 = "这是我的第二个C#程序";
            System.Console.WriteLine(message1);
            System.Console.WriteLine(message2);

            //多次赋值
            string str3, str4;
            str3 = str4 = "34";
            System.Console.WriteLine(str4);
            System.Console.WriteLine(str3);

            //输入与输出
            //案例2:与电脑进行交互_WriteLine换行
            string str5;
            System.Console.WriteLine("你的名字是:");//WriteLine换行
            str5 = System.Console.ReadLine();
            System.Console.WriteLine("我的名字是:{0}",str5);
            System.Console.ReadKey();
            /*
             * 变量名的命名规则参见图1
             * 
             */
        }
    }
}
