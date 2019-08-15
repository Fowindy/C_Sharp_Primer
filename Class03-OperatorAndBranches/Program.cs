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
            //一元运算符:+(正号);-(负号);
            //二元运算符:+(加);-(减);*(乘);/(除);%(取余);=(赋值);++(自增);--(自减);+=;-=;*=;/=;%=;
            //二元运算符:a++与++a的区别(++a:++在前;先自增后赋值)
            int a = 10;
            int b;
            b = ++a;//++在前;先自增后赋值
            Console.WriteLine(b);//11
            Console.WriteLine(a);//11
            Console.Read();
        }
    }
}
