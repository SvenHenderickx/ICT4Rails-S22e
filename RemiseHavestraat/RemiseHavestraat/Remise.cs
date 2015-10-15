using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    class Remise
    {
        #region RemiseSpecs
        private static Remise instance;

        private Remise() {}

        public static Remise Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Remise();
                }
                return instance;
            }
        }

        public string Naam
        {
            get;
            private set;
        }

        public bool RemiseNaam(string naam)
        {
            Naam = naam;
            return true;
        }
        #endregion

        #region Initialisation
        public bool InlogControle(string inlognaam, string wachtwoord)
        {
            return false;
        }
        #endregion

        #region methodes

        public bool InlogControle(string inlogNaam)
        {
            return false;
        }

        public bool MedewerkersOphalen()
        {
            return false;
        }

        public bool TramsOphalen()
        {
            return false;
        }

        public bool SporenOphalen()
        {
            return false;
        }

        public bool SegmentenOphalen()
        {
            return false;
        }

        public bool SchoonmaakBeurtenOphalen()
        {
            return false;
        }

        public bool ServiceBeurtenOphalen()
        {
            return false;
        }

        public bool LijnenOphalen()
        {
            return false;
        }

        public bool SegmentUpdate(Tram tram, Segment segment)
        {
            return false;
        }

        public bool VoegLijnToe(Tram tram, List<Medewerker> medewerkers, DateTime vertrek, DateTime aankomst)
        {
            return false;
        }

        public bool VoegReserveringToe(Tram tram, Spoor spoor)
        {
            return false;
        }

        public bool VoegSchoonmaakBeurtToe(Tram tram, List<Medewerker> medewerkers, int type, int prioriteit, string beschrijving, DateTime datumTijdBegin)
        {
            return false;
        }

        public bool VoegServiceBeurtToe(Tram tram, List<Medewerker> medewerkers, int type, int prioriteit, string beschrijving, DateTime datumTijdBegin)
        {
            return false;
        }

        public bool SchoonmaakBeurtAftekenen(DateTime datumTijdEind)
        {
            //invoeren schoonmaakbeurt
            return false;
        }

        public bool ServiceBeurtAftekenen(DateTime datumTijdEind)
        {
            //invoeren servicebeurt
            return false;
        }




        #endregion
    }
}
