using System.Collections.Generic;

namespace WrapMethod
{
    public class ZeitbuchungRepository
    {
        public List<Zeitbuchung> GetZeitbuchungen()
        {
            return new List<Zeitbuchung>
            {
                new Zeitbuchung() { IstZeiten = 9M},
                new Zeitbuchung() { IstZeiten = 9M},
                new Zeitbuchung() { IstZeiten = 9M},
                new Zeitbuchung() { IstZeiten = 9M},
                new Zeitbuchung() { IstZeiten = 4M}
            };
        }
    }
}
