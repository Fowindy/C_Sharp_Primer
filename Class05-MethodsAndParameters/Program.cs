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
        //例子7-2:统计目标目录下文件总数_递归实现_有异常
        /*
         * 理解 file和directory
         */
        static long FileOrDirCount(string path)
        {
            long count = 0;
            //统计文件file的个数:
            var files = Directory.GetFiles(path);
            count += files.Length;

            //统计子目录directory的个数
            var dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                count += FileOrDirCount(dir);
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("正在统计中...");
            Console.WriteLine("该目录文件总数为:{0}", FileOrDirCount("D:/"));
            Console.Read();
        }
    }
}
