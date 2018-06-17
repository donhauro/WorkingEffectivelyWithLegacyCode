using System;

namespace WrapMethod.Version2
{
    public class Mitarbeiter
    {
        public string Name { get; set; }
        public decimal Stundensatz { get; set; }
        public DateTime LetzteAuszahlung { get; set; }

        private void AuszahlenDurchführen()
        {
            var zeitbuchungRepository = new ZeitbuchungRepository();
            var auszahlungssystem = new Version2.Auszahlungssystem();

            var lohn = 0M;

            foreach (var tagesbuchung in zeitbuchungRepository.GetZeitbuchungen())
            {
                lohn += tagesbuchung.IstZeiten * Stundensatz;
            }

            auszahlungssystem.GeldAuszahlen(this, lohn);
        }

        public void Auszahlen()
        {
            LogPayment();
            AuszahlenDurchführen();
        }

        private void LogPayment()
        {
            LetzteAuszahlung = DateTime.Now;
        }
    }
}