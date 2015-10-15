using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Tram
    {
        public enum Type { Combino, Dubbelkop, Opleidingstrams, ElfG, TwaalfG };
        public enum Status { Defect, Schoonmaak, Dienst, Remise };

        public int Lengte { get; private set; }
        public int TramNummer { get; private set; }
        public Type TreinType { get; private set; }
        public Status TreinStatus { get; private set; }

        public Tram(int tramNummer, int lengte, int type, int status)
        {
            this.TramNummer = tramNummer;
            this.Lengte = lengte;
            this.TreinType = (Type)type;
            this.TreinStatus = (Status)status;
            // enums initialiseren       
        }
    }
}
