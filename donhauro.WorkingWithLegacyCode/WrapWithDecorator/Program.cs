using System;

namespace WrapWithDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mitarbeiter = new Mitarbeiter() { Stundensatz = 15M};
            var istZeit = 5.5M;

            var buchung = new Feiertagsbuchung(new Ueberstundenbuchung(new Buchung(mitarbeiter, istZeit)));

            Console.WriteLine(buchung.GetIstKosten());
            Console.Read();
        }
    }
}
