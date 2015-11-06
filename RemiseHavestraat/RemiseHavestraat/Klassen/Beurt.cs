using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Beurt
    {
        public DateTime DatumTijdBegin { get; private set; }
        public DateTime DatumTijdEind { get; set; }
        public string Beschrijving { get; private set; }
        public SoortBeurt BeurtSoort { get; private set; }
        public EnumPrioriteitBeurt PrioriteitBeurt { get; set; }
        public List<Medewerker> Medewerkers { get; set; }
        public Tram Tram { get; private set; }

        public Beurt(DateTime datumtijdbegin, string beschrijving, Tram tram, SoortBeurt soort)
        {
            this.DatumTijdBegin = datumtijdbegin;
            this.Beschrijving = beschrijving;
            this.Tram = tram;
            this.BeurtSoort = soort;
        }

        public override string ToString()
        {
            return DatumTijdBegin.ToString() + " - " + PrioriteitBeurt + " - " + BeurtSoort + ": " + Beschrijving;
        }
    }
}
