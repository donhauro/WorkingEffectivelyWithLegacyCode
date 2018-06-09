using System;
using SproutOutClass.Version1;
using QuarterlyReportGenerator = SproutOutClass.Version2.QuarterlyReportGenerator;

namespace SproutOutClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var quarterlyReportGenerator = new QuarterlyReportGenerator();
            Console.WriteLine(quarterlyReportGenerator.GenerateHtml());
            Console.ReadKey();
        }
    }
}
