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
            this.TramID = tramID;
            this.SpoorID = spoorID;
        }
    }
}
