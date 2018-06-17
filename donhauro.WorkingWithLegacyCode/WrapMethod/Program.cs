using WrapMethod.Version2;

namespace WrapMethod
{
    class Program2
    {
        static void Main2(string[] args)
        {
            var mitarbeiter = new Mitarbeiter() { Name = "Michael S.", Stundensatz = 28M };
            mitarbeiter.Auszahlen();
        }

    }
}
