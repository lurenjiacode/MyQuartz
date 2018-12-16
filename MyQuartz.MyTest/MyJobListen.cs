using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuartz.MyTest
{

    //监听任务
    public class MyJobListen : IJobListener
    {
        public string Name => "hello world listening...";

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            Console.WriteLine("JobExecutionVetoed:被否决执行了");
            //throw new NotImplementedException();
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            Console.WriteLine("JobToBeExecuted:开始执行的监听");
            //throw new NotImplementedException();
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            Console.WriteLine("JobWasExecuted:结束执行的监听\n");
            //throw new NotImplementedException();
        }

    }
}
