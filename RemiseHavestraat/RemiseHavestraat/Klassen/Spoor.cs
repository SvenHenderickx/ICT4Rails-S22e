using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemiseHavestraat
{
    public class Spoor
    {
        public int ID { get; private set; }
        public int RemiseID { get; private set; }
        public int Nummer { get; private set; }

        public Spoor(int id, int remiseID, int nummer)
        {
            this.ID = id;
            this.RemiseID = remiseID;
            this.Nummer = nummer;
        }
    }
}
