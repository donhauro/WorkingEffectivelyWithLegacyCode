namespace WrapMethod.Version1
{
    public class Mitarbeiter
    {
        public string Name { get; set; }
        public decimal Stundensatz { get; set; }

        public void Auszahlen()
        {          
            var zeitbuchungRepository = new ZeitbuchungRepository();
            var auszahlungssystem = new Auszahlungssystem();

            var lohn = 0M;

            foreach (var tagesbuchung in zeitbuchungRepository.GetZeitbuchungen())
            {
                lohn += tagesbuchung.IstZeiten * Stundensatz;
            }

            auszahlungssystem.GeldAuszahlen(this, lohn);
        }
    }
}