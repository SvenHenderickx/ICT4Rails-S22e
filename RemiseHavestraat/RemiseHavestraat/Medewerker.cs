using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Medewerker
    {
        public string MedewerkerNaam { get; private set; }
        bool MedewerkerBeschikbaar = false;

        public Medewerker(string medewerkerNaam)
        {
            this.MedewerkerNaam = medewerkerNaam;
        }
    }
}
