﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
