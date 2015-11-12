using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemiseHavestraat.Klassen;

namespace RemiseHavestraat
{
    public class Tram
    {
        public enum Type { Combino, Dubbelkop, Opleidingstrams, ElfG, TwaalfG };
        


        public int TramID { get; private set; }
        public int TramNr { get; private set; }
        public int LijnID { get; private set; }
        public Type TypeEnum { get; private set; }
        public int Lengte { get; private set; }
        public StatusEnum StatusEnum { get; set; }

        public Tram(int tramID, int tramNr, int lijnID, int type, int lengte, int status)
        {
            this.TramID = tramID;
            this.TramNr = tramNr;
            this.LijnID = lijnID;
            this.TypeEnum = (Type)type;
            this.Lengte = lengte;
            this.StatusEnum = (StatusEnum)status;
        }

        public override string ToString()
        {
            return TramNr + " - " + TypeEnum + " - " + StatusEnum;
        }
    }
}
