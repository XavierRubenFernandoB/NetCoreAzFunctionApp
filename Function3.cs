using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace NetCoreAzFunctionApp
{
    public static class Function3
    {
        [FunctionName("myVSBLOBTrigger")]
        public static void Run([BlobTrigger("myfreecontainer/{name}")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
