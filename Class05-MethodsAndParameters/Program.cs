using Class05_MethodsAndParameters2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_MethodsAndParameters
{
    class Program
    {
        //例子7-2:统计目标目录下文件总数_递归实现_异常处理_文件计算成功
        /*
         * 理解 file和directory
         */

        static long FileOrDirCount(string path)
        {
            long count = 0;
            //捕获异常:try{}catch(){}finally{}
            try
            {
                //统计文件file的个数:
                var files = Directory.GetFiles(path);
                count += files.Length;
                //统计子目录directory的个数
                var dirs = Directory.GetDirectories(path);
                foreach (var dir in dirs)
                {
                    count += FileOrDirCount(dir);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                //打印异常
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex2)
            {
                //打印异常
                Console.WriteLine(ex2.Message);
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("正在统计中...");
            Console.WriteLine("该目录文件总数为:{0}", FileOrDirCount(@"J:\Documents\学习笔记"));
            Console.Read();
        }
    }
}
