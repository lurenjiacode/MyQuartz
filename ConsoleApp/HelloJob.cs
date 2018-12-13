using Quartz;
using System;

namespace ConsoleApp
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