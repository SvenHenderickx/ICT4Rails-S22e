using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Medewerker
    {
        public string Naam { get; private set; }

        public EnumMedewerkerRol Rol { get; private set; }

        public Medewerker(string medewerkerNaam, int rol)
        {
            this.Naam = medewerkerNaam;
            this.Rol = (EnumMedewerkerRol)rol;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
