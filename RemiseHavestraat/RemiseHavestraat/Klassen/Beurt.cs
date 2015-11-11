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
        public EnumTypeBeurt Type { get; private set; }
        //public EnumPrioriteitBeurt PrioriteitBeurt { get; set; }
        public List<Medewerker> Medewerkers { get; set; }
        public int TramID { get; private set; }

        public Beurt(DateTime datumtijdbegin, DateTime datumtijdEind, string beschrijving, int tramID, EnumTypeBeurt type)
        {
            this.DatumTijdBegin = datumtijdbegin;
            this.DatumTijdBegin = datumtijdEind;
            this.Beschrijving = beschrijving;
            this.TramID = tramID;
            this.Type = type;
        }

        /*
        public override string ToString()
        {
            return DatumTijdBegin.ToString() + " - " + PrioriteitBeurt + " - " + BeurtSoort + ": " + Beschrijving;
        }
         * */
    }
}
