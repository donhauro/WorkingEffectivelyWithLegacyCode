namespace WrapWithDecorator
{
    public class Ueberstundenbuchung: IBuchung
    {
        private readonly IBuchung Buchung;

        public Ueberstundenbuchung(IBuchung buchung)
        {
            Buchung = buchung;
        }

        public decimal GetIstKosten()
        {
            return Buchung.GetIstKosten() * 1.1M;
        }
    }
}
