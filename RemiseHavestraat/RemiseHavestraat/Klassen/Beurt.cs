using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Beurt
    {
        public enum Soort { Schoonmaakbeurt, Servicebeurt };

        public DateTime DatumTijdBegin { get; private set; }
        public DateTime DatumTijdEind { get; private set; }
        public string Beschrijving { get; private set; }
        public Soort BeurtSoort { get; private set; }
        public EnumPrioriteitBeurt PrioriteitBeurt { get; private set; }

        public Beurt(DateTime datumtijdbegin, DateTime datumtijdeind, string beschrijving, int soort, int prioriteitbeurt)
        {
            this.DatumTijdBegin = datumtijdbegin;
            this.DatumTijdEind = datumtijdeind;
            this.Beschrijving = beschrijving;
            this.BeurtSoort = (Soort)soort;
            this.PrioriteitBeurt = (EnumPrioriteitBeurt)prioriteitbeurt;
        }
    }
}
