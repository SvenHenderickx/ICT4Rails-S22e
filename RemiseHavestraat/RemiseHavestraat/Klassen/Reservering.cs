using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    class Reservering
    {
        public int ID { get; private set; }
        public Tram tram { get; private set; }
        public Spoor spoor { get; private set; }

        public Reservering(int id, Tram tram, Spoor spoor)
        {
            this.ID = id;
            this.tram = tram;
            this.spoor = spoor;
        }
    }
}
