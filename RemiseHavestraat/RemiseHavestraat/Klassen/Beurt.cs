using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Beurt
    {
        public int ID { get; private set; }
        public DateTime DatumTijdBegin { get; private set; }
        public DateTime DatumTijdEind { get; set; }
        public string Beschrijving { get; private set; }
        public EnumTypeBeurt Type { get; private set; }
        //public EnumPrioriteitBeurt PrioriteitBeurt { get; set; }
        public List<Medewerker> Medewerkers { get; set; }
        public int TramID { get; private set; }

        public Beurt(int id,DateTime datumtijdbegin, DateTime datumtijdEind, string beschrijving, int tramID, EnumTypeBeurt type)
        {
            this.ID = id;
            this.DatumTijdBegin = datumtijdbegin;
            this.DatumTijdEind = datumtijdEind;
            this.Beschrijving = beschrijving;
            this.TramID = tramID;
            this.Type = type;
        }

       
        public override string ToString()
        {
            int tramNr = Convert.ToInt32(Remise.Instance.GeefTramNr(TramID));

            string type = "";
            if (Type == EnumTypeBeurt.GroteSchoonmaak || Type == EnumTypeBeurt.GroteService)
                type = "Groot";
            else if (Type == EnumTypeBeurt.KleineSchoonmaak || Type == EnumTypeBeurt.KleineService)
                type = "Klein";

            if (DatumTijdEind.ToString(("d-M-y")) == "1-1-1")
            {
                return tramNr + " - " + type + " - " + DatumTijdBegin.ToString("dd-MM-yyyy") + " - " + "Geen tijdsindicatie" + " - " + Beschrijving;
            }
            else
            {
                return tramNr + " - " + type + " - " + DatumTijdBegin.ToString("dd-MM-yyyy") + " - " + DatumTijdEind.ToString("dd-MM-yyyy") + " - " + Beschrijving;
            }

        }
         
    }
}
