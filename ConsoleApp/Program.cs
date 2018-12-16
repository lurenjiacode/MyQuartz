using MyQuartz.MyTest;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");


            Test test = new Test();
            test.start();


            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
