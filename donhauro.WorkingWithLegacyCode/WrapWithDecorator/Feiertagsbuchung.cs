namespace WrapWithDecorator
{
    public class Feiertagsbuchung: IBuchung
    {
        private readonly IBuchung Buchung;

        public Feiertagsbuchung(IBuchung buchung)
        {
            Buchung = buchung;
        }

        public decimal GetIstKosten()
        {
            return Buchung.GetIstKosten() * 1.5M;
        }
    }
}
