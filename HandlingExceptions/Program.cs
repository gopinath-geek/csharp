using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"D:\Gopinath\development\csharp\8.12\HandlingExceptions\ReadFile.tx");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException NoFileEx)
            {
                Console.WriteLine("Check existence of file");
            }
            catch (DirectoryNotFoundException NoDirEx)
            {
                Console.WriteLine("Check For the Direcory existence");
            }
            //finally
            //{
            //    Executable part after all catch statments
            //    Console.WriteLine("Something went wrong");
            //}
            Console.ReadKey();
        }
    }
}
