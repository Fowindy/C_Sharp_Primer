using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //关于转义字符(\n换行)
            string str1 = "123\n123";//换行
            char ch1 = '\n';
            Console.WriteLine(str1);
            Console.Read();
        }
    }
}
