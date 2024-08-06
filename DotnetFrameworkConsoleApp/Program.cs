using DotnetStandardPractice;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFrameworkConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(FileStream).Assembly.Location);

            FileStreamPractice practice = new();
        }
    }
}
