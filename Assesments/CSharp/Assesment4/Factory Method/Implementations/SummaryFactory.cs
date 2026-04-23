using System;
using Factory_Method.Interfaces;
using Factory_Method.Implementations;

namespace Factory_Method.Creator
{
    public class SummaryReportCreator : ReportCreator
    {
        public override IAnalyticsFactory CreateReport()
        {
            return new SummaryReport();
        }
    }
}