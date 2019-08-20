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
        //例子8-2:继续修改,加入计算文件或计算目录的开关_后缀目标文件计算_验证OK
        /*
         * 理解 file和directory
         */
        static long FileOrDirCount(string path,bool onlyFiles,bool onlyDir,String extension)
        {
            long count = 0;
            //捕获异常:try{}catch(){}finally{}
            try
            {
                if (!onlyDir)
                {
                    //统计文件file的个数:
                    var files = Directory.GetFiles(path);
                    if (!string.IsNullOrEmpty(extension))
                    {
                        foreach (var file in files)
                        {
                            if (file.ToLower().EndsWith(extension))
                            {
                                count++;
                            }
                        }
                    }
                    else
                    {
                        count += files.Length;
                    }
                }
                var dirs = Directory.GetDirectories(path);
                if (!onlyFiles)
                {
                    //统计子目录directory的个数
                    count += dirs.Length;
                }
                foreach (var dir in dirs)
                {
                    count += FileOrDirCount(dir, onlyFiles,onlyDir, extension);
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

        //例子9:Main的参数,返回值:
        //返回值可以是void或者int类型,返回0为程序运行成功,返回其他的负数为运行出错
        static void Main(string[] args)
        {
            Console.WriteLine("正在统计中...");
            Console.WriteLine("该目录文件总数为:{0};文件夹的个数为:{1};目标文件的个数为:{2}", FileOrDirCount(@"J:\Documents\学习笔记",true,false,null), FileOrDirCount(@"J:\Documents\学习笔记",false,true,null), FileOrDirCount(@"J:\Documents\学习笔记", true, false, ".txt"));
            Console.Read();
        }
    }
}
