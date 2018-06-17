using WrapMethod.Version2;

namespace WrapMethod
{
    class Program
    {


        static void Main(string[] args)
        {
            var mitarbeiter = new Mitarbeiter() { Name = "Michael S.", Stundensatz = 28M };
            mitarbeiter.Auszahlen();
        }

        
    }
}
