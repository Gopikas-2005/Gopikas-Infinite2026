using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementations
{
    public class SummaryReport : IAnalyticsFactory
    {
        public void GetReports()
        {
            Console.WriteLine("Summary Report is being generated...");
        }
    }
}