using System.ComponentModel.Design;

namespace donhauro.WorkingWithLegacyCode.Console001
{
    class Program
    {
        static void Main(string[] args)
        {
            //composition root
            var sale = new Sale(new Arc456Display());
            sale.Scan("Milch 0,89 €");
        }
    }

    public class Sale
    {
        private readonly IDisplay Display;


        public Sale(IDisplay display)
        {
            Display = display;
        }

        public void Scan(string barcode)
        {
            Display.ShowLine(barcode);
        }
    }

    public interface IDisplay
    {
        void ShowLine(string barcode);
    }

    public class Arc456Display : IDisplay
    {
        public void ShowLine(string barcode)
        {
            //Use Hardware to display barcode on Screen
        }
    }

}
