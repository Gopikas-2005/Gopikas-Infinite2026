using System;
using Factory_Method.Interfaces;
using Factory_Method.Implementations;

namespace Factory_Method.Creator
{
    public class ChartReportCreator : ReportCreator
    {
        public override IAnalyticsFactory CreateReport()
        {
            return new ChartReport();
        }
    }
}