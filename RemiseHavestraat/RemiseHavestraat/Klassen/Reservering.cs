using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Reservering
    {
        public int TramID { get; private set; }
        public int SpoorID { get; private set; }

        public Reservering(int tramID, int spoorID)
        {;
            TramID = tramID;
            SpoorID = spoorID;

        }

        public override string ToString()
        {
           int TramNr = Convert.ToInt32(Remise.Instance.GeefTramNr(TramID));
           int SpoorNr = Remise.Instance.GeefSpoorNr(SpoorID);
           return "Tram " + TramNr + " - " + "Spoor " + SpoorNr;
        }
    }
}
