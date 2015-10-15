using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemiseHavestraat
{
    public class Segment
    {
        public int SegmentID { get; private set; }
        public int SegmentNummer { get; private set; }
        public int Lengte { get; private set; }

        public Segment(int segmentID, int segmentNummer, int lengte)
        {
            this.SegmentID = segmentID;
            this.SegmentNummer = segmentNummer;
            this.Lengte = lengte;
        }
    }
}
