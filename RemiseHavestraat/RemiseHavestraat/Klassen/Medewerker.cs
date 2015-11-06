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

        public EnumMedewerkerRol MedewerkerRol { get; private set; }

        public Medewerker(string medewerkerNaam, int rol)
        {
            this.MedewerkerNaam = medewerkerNaam;
            this.MedewerkerRol = (EnumMedewerkerRol)rol;
        }
    }
}
