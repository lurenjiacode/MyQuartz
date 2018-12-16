using Quartz;
using System;

namespace MyQuartz.MyTest
{
    public class HelloJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //throw new System.NotImplementedException();
            Console.WriteLine("hello job");
        }
    }
}