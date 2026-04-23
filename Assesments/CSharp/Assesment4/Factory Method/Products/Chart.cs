using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementations
{
    public class ChartReport : IAnalyticsFactory
    {
        public void GetReports()
        {
            Console.WriteLine("Chart Report is being generated...");
        }
    }
}