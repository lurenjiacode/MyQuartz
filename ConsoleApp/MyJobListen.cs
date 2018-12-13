using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //监听任务
    public class MyJobListen : IJobListener
    {
        public string Name => throw new NotImplementedException();

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            throw new NotImplementedException();
        }
    }
}
