using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class SchoonmaakBeurt : Beurt
    {
        public SchoonmaakBeurt(DateTime datumtijdbegin, DateTime datumtijdeind, string beschrijving, int soort, int prioriteitbeurt, string tramnummer, List<Medewerker> medewerkers) : base(datumtijdbegin, datumtijdeind, beschrijving, soort, prioriteitbeurt, tramnummer, medewerkers)
        {

        }
    }
}
