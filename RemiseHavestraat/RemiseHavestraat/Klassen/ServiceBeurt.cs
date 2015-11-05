using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemiseHavestraat
{
    public enum TypeBeurt { GroteSchoonmaak, KleineSchoonmaak, GroteServicebeurt, KleineServicebeurt }

    public class ServiceBeurt
    {

        public int TramID { get; private set; }
        public DateTime DatumTijdBegin { get; set; }
        public DateTime DatumTijdEind { get; set; }
        public string Beschrijving { get; set; }

        public List<Medewerker> Medewerkers { get; set; }

        public ServiceBeurt(int tramID, DateTime datumtijdbegin, DateTime datumtijdeind, string beschrijving, TypeBeurt typeBeurt)
        {
            this.DatumTijdBegin = datumtijdbegin;
            this.DatumTijdEind = datumtijdeind;
            this.Beschrijving = beschrijving;
            this.TramID = tramID;
        }
    }
}
