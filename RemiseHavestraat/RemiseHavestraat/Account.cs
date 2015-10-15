﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiseHavestraat
{
    public class Account
    {
        //Properties
        public string InlogNaam { get; private set; }
        public EnumMedewerkerRol MedewerkerRol{ get; private set; }

        //Constructors
        Account(string inlogNaam, int medewerkerRol)
        {
            InlogNaam = inlogNaam;
            MedewerkerRol = (EnumMedewerkerRol)medewerkerRol;
        }
    }
}