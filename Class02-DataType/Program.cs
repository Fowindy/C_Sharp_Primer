using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//使用秒表需要引用Diagnostics

namespace Class02_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //字面值(默认值)(整数->int;小数->double)
            //double num = 12312323.123456789123456789;
            Console.WriteLine(12312323.123456789123456789);//12312323.1234568   //15位有效数字
            //Console.Read();//暂停控制台

            //金融数据decimal类型(涉及到金钱全部使用decimal)(28~29位有效数字)

            //字面值(指数形式E代表以10为底)
            double a = 2E10;//20000000000   //2*10^10
            Console.WriteLine(a);

            //字面值(十六进制)
            int b = 0xff;
            Console.WriteLine(b);//255

            //bool类型(true/false)
            bool isCool = true;
            Console.WriteLine(isCool);//True

            //char类型(单引号,只存储一个字符)
            string str = "123";
            char ch = '1';

            //关于转义字符(\n换行)(\t制表符)
            string str1 = "123\t123";//对齐
            string str2 = "1234\t123";
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            //关于转义字符1(输出\t使用\\t)
            string str3 = "12345\\t1234";
            Console.WriteLine(str3);//12345\t1234

            //关于转义字符1(输出"使用\")
            string str4 = "12345\"1234";
            Console.WriteLine(str4);//12345"1234

            //关于转义字符2(电脑叫一下使用\a)
            string str5 = "12345\a1234";
            Console.WriteLine(str5);

            //关于嵌入转义字符@(一般用于路径,作用:忽略转义)
            string str6 = @"J:\Documents\学习笔记\学习截图";
            Console.WriteLine(str6);//J:\Documents\学习笔记\学习截图

            //字符串的点方法(ToUpper方法将目标字符转换成大写(字符串不可变性:转换失败))
            string str7 = "abc";
            str7.ToUpper();//ToUpper方法将目标字符转换成大写
            Console.WriteLine(str7);//abc

            //字符串的点方法(ToUpper方法将目标字符转换成大写(重新赋值,转换成功))
            string str8 = "abc";
            str8 = str8.ToUpper();
            Console.WriteLine(str8);//ABC

            //string类型和StringBuilder的区别(使用秒表来测量两者运行效率)
            Stopwatch 计时器 = new Stopwatch();//不建议用中文(为了演示)
            计时器.Start();//开始计时
            //string str9 = string.Empty;//空相当于null
            //for (int i = 0; i < 100000; i++)
            //{
            //    str9 += i.ToString();//012345678......
            //}

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i.ToString());
            }
            计时器.Stop();//结束计时
            Console.WriteLine(计时器.ElapsedMilliseconds);//14471  //显示用时

            //类型的分类:
            //值类型:所有基本类型都是
            //引用类型:目前为止string

            //null没有引用任何有效对象(null专用于引用类型)
            string str10 = string.Empty;//string.Empty等价于''
            //string.Empty 没有;null 空,没有输入

            //
            Console.Read();
        }
    }
}
