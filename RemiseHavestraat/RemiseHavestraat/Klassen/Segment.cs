using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemiseHavestraat
{
    public class Segment
    {
        public int SpoorID { get; private set; }
        public int Nummer { get; private set; }
        public int Tram_ID { get; set; }

        public Segment(int spoorID, int nummer, int tram_ID)
        {
            this.SpoorID = spoorID;
            this.Nummer = nummer;
            this.Tram_ID = tram_ID;
        }
    }
}
