using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.DirectoryServices;

namespace AzureFunctionApp
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static void Run([TimerTrigger(" 0 * * * * *")]TimerInfo myTimer, ILogger log)
        {
			var directoryEntry = new DirectoryEntry();
			log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
