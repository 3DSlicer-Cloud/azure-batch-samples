﻿using System;

namespace Microsoft.Azure.Batch.Samples.TextSearch
{
    /// <summary>
    /// The main program for the JobSubmitter
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                JobSubmitter jobSubmitter = new JobSubmitter();

                jobSubmitter.RunAsync().Wait();
            }
            catch (AggregateException e)
            {
                Helpers.ProcessAggregateException(e);

                throw;
            }
            
        }
    }
}
