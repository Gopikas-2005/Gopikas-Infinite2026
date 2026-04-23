using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementations
{
    public class TabularReport : IAnalyticsFactory
    {
        public void GetReports()
        {
            Console.WriteLine("Tabular Report is being generated...");
        }
    }
}