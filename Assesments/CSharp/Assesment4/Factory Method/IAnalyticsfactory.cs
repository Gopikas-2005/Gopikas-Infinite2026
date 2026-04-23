using System;
using Factory_Method.Interfaces;

namespace Factory_Method.Creator
{
    public abstract class ReportCreator
    {
        public abstract IAnalyticsFactory CreateReport();

        public void GenerateReport()
        {
            IAnalyticsFactory report = CreateReport();
            report.GetReports();
        }
    }
}