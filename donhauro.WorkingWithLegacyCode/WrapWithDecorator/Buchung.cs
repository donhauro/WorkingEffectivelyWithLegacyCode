using System;

namespace WrapWithDecorator
{
    public class Buchung : IBuchung
    {
        private readonly Mitarbeiter Mitarbeiter;
        private readonly decimal Istzeit;        

        public Buchung(Mitarbeiter mitarbeiter, decimal istzeit)
        {
            Mitarbeiter = mitarbeiter;
            Istzeit = istzeit;
        }

        public decimal GetIstKosten()
        {
            return Mitarbeiter.Stundensatz * Istzeit;
        }        
    }
}
