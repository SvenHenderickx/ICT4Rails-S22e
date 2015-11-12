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
            HaalReserveringenOp();
            BeurtenOphalen();
            MedewerkersOphalen();
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

        public bool StatusUpdate(int tramID, string tramstatus)
        {
            if (db.UpdateTramStatus(tramID, tramstatus))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spoorNr"></param>
        /// <returns></returns>
        public bool BestaatSpoor(int spoorNr)
        {
            if (Sporen.Find(x => x.Nummer == spoorNr) == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tramnummer"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tramNr"></param>
        /// <param name="spoorNr"></param>
        /// <param name="segmentNr"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Segment> GeefSegmenten()
        {
            return segmenten;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tramID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spoorID"></param>
        /// <returns></returns>
        public int GeefSpoorNr(int spoorID)
        {
            foreach (var s in Sporen)
            {
                if (s.ID == spoorID)
                {
                    return s.Nummer;
                }
            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spoorNr"></param>
        /// <param name="segmentNr"></param>
        /// <returns></returns>
        public bool BlokkeerSegment(int spoorNr, int segmentNr)
        {
           return db.BlokkeerSegment(spoorNr, segmentNr);
        }

        /// <summary>
        /// 
        /// </summary>
        public void RefreshSegmenten()
        {
            segmenten = db.HaalSegmentenOp();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetOverzicht()
        {
            db.ResetOverzicht();
            RefreshSegmenten();
        }

        public void Simulatie()
        {
            db.Simulatie();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Segment> HaalSegmentenRandomOp()
        {
            return db.HaalSegmentenRandomOp();
        }

        public bool HaalReserveringenOp()
        {
           List<Reservering> tempReserveringen = db.HaalReserveringenOp();

            if (tempReserveringen == null)
            {
                return false;
            }
            else
            {
                reserveringen = tempReserveringen;
                return true;
            }
        }

        public bool MaakReservering(int tramNr, int spoorNr)
        {
          return db.MaakReservering(tramNr, spoorNr);
        }

        public bool BestaatReservering(int tramNr, int spoorNr)
        {
            Tram t = Trams.Find(x => x.TramNr == tramNr); // vind tram
            Spoor s = Sporen.Find(x => x.Nummer == spoorNr); // vind spoor

            if (reserveringen.Find(x => x.TramID == t.TramID && x.SpoorID == s.ID) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool NieuweBeurt(DateTime datumtijdBegin, DateTime datumtijdEind,string beschrijving, Tram tram, EnumTypeBeurt type)
        {
           return db.NieuweBeurt(tram.TramID, datumtijdBegin, datumtijdEind, beschrijving, type);
        }

        public List<Beurt> SchoonmaakBeurtenLijstOphalen()
        {
            List<Beurt> schoonmaken = new List<Beurt>();
            if (beurten == null) return null;
            foreach (var b in beurten)
            {
                if (b.Type == EnumTypeBeurt.GroteSchoonmaak || b.Type == EnumTypeBeurt.KleineSchoonmaak)
                {
                    schoonmaken.Add(b);
                }
            }

            return schoonmaken;
        }


        public List<Beurt> ServiceBeurtenLijstOphalen()
        {
            if (Beurten == null) return null;
            List<Beurt> serviceBeurten = new List<Beurt>();

            foreach (var b in beurten)
            {
                if (b.Type == EnumTypeBeurt.KleineService || b.Type == EnumTypeBeurt.GroteService)
                {
                    serviceBeurten.Add(b);
                }
            }

            return serviceBeurten;
        }

        public bool BeurtenOphalen()
        {
            List<Beurt> tempBeurten = db.HaalBeurtenOp();

            if (tempBeurten == null)
            {
                return false;
            }
            else
            {
                beurten = tempBeurten;
                return true;
            }
        }

        public List<Medewerker> TechniciOphalen()
        {
            if (medewerkers == null) return null;

            List<Medewerker> technici = new List<Medewerker>();

            foreach (var m in medewerkers)
            {
                if (m.Rol == EnumMedewerkerRol.Technicus)
                {
                    technici.Add(m);
                }
            }

            return technici;
        }

        public List<Medewerker> SchoonmakersOphalen()
        {
            if (medewerkers == null) return null;

            List<Medewerker> schoonmakers = new List<Medewerker>();

            foreach (var m in medewerkers)
            {
                if (m.Rol == EnumMedewerkerRol.Schoonmaker)
                {
                    schoonmakers.Add(m);
                }
            }

            return schoonmakers;
        }


        public bool VerwijderBeurt(int beurtID)
        {
           return db.VerwijderServicebeurt(beurtID);
        }

        public int GeefChauffeurSpoor(int tramNr)
        {
            return db.GeefChauffeurSpoor(tramNr);
        }
        


        #endregion


    }
}
