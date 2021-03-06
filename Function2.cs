using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace NetCoreAzFunctionApp
{
    public static class Function2
    {
        [FunctionName("myVSQueueTrigger")]
        public static void Run([QueueTrigger("myfreequeue")]string myQueueItem, ILogger log)
        {
            //throw new Exception("error from VS"); //to create _poison queue
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
