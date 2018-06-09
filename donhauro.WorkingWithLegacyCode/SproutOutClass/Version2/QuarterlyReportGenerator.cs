namespace SproutOutClass.Version2
{
    public class QuarterlyReportTableHeaderGenerator
    {
        public string MakeHeader()
        {
            return "<tr><td>TotalSum</td><td>Quantity</td><td>Product</td><td>Description</td>";
        }
    }

    public class QuarterlyReportGenerator
    {
        public string GenerateHtml()
        {
            var records = TheEvilDatabase.GetRecords();

            var pageText = string.Empty;
            pageText += "<html>";
            pageText += "   <head>";
            pageText += "       <title>Quarterly Report</title>";
            pageText += "   </head>";
            pageText += "   <body>";
            pageText += "       <table>";

            if (records.Count > 0)
            {
                new QuarterlyReportTableHeaderGenerator().MakeHeader();

                foreach (var record in records)
                {
                    pageText += "<tr>";
                    pageText += "<td>" + record.TotalSum.ToString("C") + "</td>";
                    pageText += "<td>" + record.TotalSum.ToString("C") + "</td>";
                    var buffer = $"<td>{record.Product}</td>";
                    pageText += buffer;
                    buffer = $"<td>{record.Description}</td>";
                    pageText += buffer;
                    pageText += "</tr>";
                }
            }
            else
            {
                pageText += "No results for this period";
            }

            pageText += "       </table>";
            pageText += "   </body>";
            pageText += "</html>";

            return pageText;
        }
    }
}
