using System;

namespace WrapMethod.Variante
{
    public class Mitarbeiter
    {
        public string Name { get; set; }
        public decimal Stundensatz { get; set; }
        public DateTime LetzteAuszahlung { get; set; }

        public void Auszahlen()
        {
            var zeitbuchungRepository = new ZeitbuchungRepository();
            var auszahlungssystem = new Variante.Auszahlungssystem();

            var lohn = 0M;

            foreach (var tagesbuchung in zeitbuchungRepository.GetZeitbuchungen())
            {
                lohn += tagesbuchung.IstZeiten * Stundensatz;
            }

            auszahlungssystem.GeldAuszahlen(this, lohn);
        }

        public void LoggedAuszahlen()
        {
            LogPayment();
            Auszahlen();
        }

        private void LogPayment()
        {
            LetzteAuszahlung = DateTime.Now;
        }
    }
}