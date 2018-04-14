
// ReSharper disable All

namespace donhauro.WorkingWithLegacyCode.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sale = new Sale();
            sale.Scan("Milch 0,89 €");
        }
    }

    public class Sale
    {
        private readonly Display ARC456;

        public Sale()
        {
            ARC456 = new Display();
        }

        public void Scan(string barcode)
        {
            ARC456.ShowLine(barcode);
        }
    }

    public class Display
    {
        public void ShowLine(string barcode)
        {
            //Use Hardware to display barcode on Screen
        }
    }

}
