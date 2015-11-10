using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RemiseHavestraat
{
    public class Remise
    {
        #region Fields
        public Account account;
        private List<Medewerker> medewerkers;
        private List<Segment> segmenten;
        private List<Spoor> sporen;
        private List<Tram> trams;
        private List<Reservering> reserveringen;
        private List<Beurt> beurten;

        public List<Medewerker> Medewerkers
        {
            get { return medewerkers; }
        }

        public List<Segment> Segmenten
        {
            get { return segmenten; }
        }

        public List<Spoor> Sporen
        {
            get { return sporen; }
        }

        public List<Tram> Trams
        {
            get { return trams; }
        }

        public List<Beurt> Beurten
        {
            get { return beurten; }
        }

        public List<Reservering> Reserveringen
        {
            get { return reserveringen; }
        }

        #endregion

        #region RemiseSpecs
        private static Remise instance;
        private Database db;

        private Remise() 
        {
            db = new Database();
            medewerkers = new List<Medewerker>();
            segmenten = new List<Segment>();
            sporen = new List<Spoor>();
            trams = new List<Tram>();
            reserveringen = new List<Reservering>();

            TramsOphalen();
            SegmentenOphalen();
            SporenOphalen();
        }

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
        public bool InlogControle(string gebruikersNaam, string wachtWoord)
        {
            if ((db.LogIn(gebruikersNaam, wachtWoord)) != null)
            {
                account = db.account;
                return true;
            }
            return false;
        }
        #endregion

        #region methodes
        //Deze methode haalt alle medewerkers op van de database en zet ze in de lijst
        public bool MedewerkersOphalen()
        {
            List<Medewerker> tempMedewerkers = db.HaalOpMedewerkers();
            if (tempMedewerkers == null)
            {
                return false;
            }
            else
            {
                medewerkers = tempMedewerkers;
                return true;
            }
        }

        //Deze methode haalt specifieke medewerkers op van de database en zet ze in de lijst
        public bool MedewerkersOphalen(string functie)
        {
            List<Medewerker> tempMedewerkers = db.HaalOpMedewerkers(functie);
            if (tempMedewerkers == null)
            {
                return false;
            }
            else
            {
                medewerkers = tempMedewerkers;
                return true;
            }
        }

        //Deze methode haalt specifieke medewerkers op van de database en zet ze in de lijst
        public List<Medewerker> MedewerkersZoeken(List<int> medewerkerids)
        {
            List<Medewerker> tempMedewerkers = db.ZoekMedewerkers(medewerkerids);
            return tempMedewerkers;
        }

        //Deze methode haalt alle trams op van de database en zet ze in de lijst
        public bool TramsOphalen()
        {
            List<Tram> tempTrams = db.HaalOpTrams();
            if (tempTrams == null)
            {
                return false;
            }
            else
            {
                trams = tempTrams;
                return true;
            }
            
        }

        public Tram GeefTram(int tramNr)
        {
            foreach (Tram tram in trams)
            {
                if (tram.TramNr == tramNr)
                {
                    return tram;
                }
            }
            return null;
        }

        public bool SporenOphalen()
        {
            List<Spoor> tempSporen = db.HaalOpSporen();
            if (tempSporen == null)
            {
                return false;
            }
            else
            {
                sporen = tempSporen;
                return true;
            }
        }

        public bool SegmentenOphalen()
        {
            List<Segment> tempSegmenten = db.HaalSegmentenOp();
            if (tempSegmenten == null)
            {
                return false;
            }
            else
            {
                segmenten = tempSegmenten;
                return true;
            }
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

        public bool SchoonmaakBeurtAftekenen(Beurt beurt, DateTime datumTijdEind)
        {
            //invoeren schoonmaakbeurt
            return false;
        }

        public bool ServiceBeurtAftekenen(Beurt beurt, DateTime datumTijdEind)
        {
            //invoeren servicebeurt
            return false;
        }

        public bool StatusUpdate(int tramnummer, string tramstatus)
        {
            if (db.UpdateTramStatus(tramnummer, tramstatus))
            {
                return true;
            }
            return false;
        }

      

        public bool SpoorUpdate(int spoornummer)
        {
            if (db.UpdateSpoor(spoornummer))
            {
                return true;
            }
            return false;
        }
        public List<Tram> SpoorInfo(int spoor)
        {
            List<Tram> temptram = db.InfoSpoor(spoor);
            return temptram;
        }

        public bool SpoorBlokkeren(int spoor, int segment)
        {
            return false;
        }
        #endregion



        #region methodes GIJS

        public bool TramVerwijderenSegment(int tramnummer)
        {
            if (db.VerwijderTram(tramnummer))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deze methode gaat na of een tram voorkomt in de lijst trams
        /// </summary>
        /// <param name="tramNr">Nummer van de tram</param>
        /// <returns>True wanneer de tram voorkomt anders false</returns>
        public bool BestaatTram(int tramNr)
        {
            if (Trams.Find(x => x.TramNr == tramNr) == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Deze methode gaat na of een segment voorkomt in de lijst segmenten
        /// </summary>
        /// <param name="spoorNr">Nummer van het spoor</param>
        /// <param name="segmentNr">Nummer van het segment</param>
        /// <returns>true als segment voorkomt anders false</returns>
        public bool BestaatSegment(int spoorNr, int segmentNr)
        {
            int spoorID = 0;
            foreach (var s in Sporen)
            {
                if (s.Nummer == spoorNr) spoorID = s.ID;
            }

            if (spoorID == 0)
            {
                return false;
            }

            if (segmenten.Find(x => x.SpoorID == spoorID && x.Nummer == segmentNr) == null)
            {
                return false;
            }

            foreach (var s in segmenten)
            {
                if (s.SpoorID == spoorID) ;
            }
            
            return true;
        }


        public bool PlaatsTram(int tramNr, int spoorNr, int segmentNr)
        {
           return db.PlaatsTram(tramNr, spoorNr, segmentNr);
        }

        /// <summary>
        /// Geeft het tramnummer van een tram die op een segment staat
        /// </summary>
        /// <param name="spoorNr">Het id van een segment</param>
        /// <returns>Tramnummer</returns>
        public List<Segment> GeefSegmentenVanSpoor(int spoorNr)
        {
            List<Segment> segmentenVanSpoor = new List<Segment>();
            foreach (var s in segmenten)
            {
                if (s.Nummer == spoorNr)
                {
                    segmentenVanSpoor.Add(s);
                }
                
            }
            return segmentenVanSpoor;
        }

        public List<Segment> GeefSegmenten()
        {
            return segmenten;
        }

        public string GeefTramNr(int tramID)
        {
            foreach (var t in Trams)
            {
                if (t.TramID == tramID)
                {
                    return t.TramNr.ToString();
                }
            }
            return "";
        }

        public int GeefSpoorNr(int spoorID)
        {
            foreach (var s in Sporen)
            {
                if (s.ID == spoorID)
                {
                    return s.Nummer;
                }
            }
            return 0;
        }

        public bool BlokkeerSegment(int spoorNr, int segmentNr)
        {
           return db.BlokkeerSegment(spoorNr, segmentNr);
        }


        public void RefreshSegmenten()
        {
            segmenten = db.HaalSegmentenOp();
        }

        public void ResetOverzicht()
        {
            db.ResetOverzicht();
            RefreshSegmenten();
        }

        #endregion


    }
}
