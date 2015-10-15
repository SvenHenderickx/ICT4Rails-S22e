using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemiseHavestraat
{
    public class Spoor
    {
        public int SpoorNummer { get; private set; }
        public List<Segment> Segmenten { get; private set; }

        public Spoor(int spoorNummer, List<Segment> segmenten)
        {
            this.SpoorNummer = spoorNummer;
            this.Segmenten = segmenten;
        }
    }
}
