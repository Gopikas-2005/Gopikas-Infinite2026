using System;
using Factory_Method.Creator;

namespace Factory_Method
{
    class Factory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter report type (chart/tabular/summary):");
            string input = Console.ReadLine().ToLower();

            ReportCreator creator = null;

            if (input == "chart")
                creator = new ChartReportCreator();

            else if (input == "tabular")
                creator = new TabularReportCreator();

            else if (input == "summary")
                creator = new SummaryReportCreator();

            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            creator.GenerateReport();
        }
    }
}