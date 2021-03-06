﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandStekelorum_6IB_VeelOpVeel.MijnKlasses
{
    class Sport
    {
        //velden
        int _id = 0;
        string _naam = "";
        List<Persoon> _personen = new List<Persoon>();

        //properties
        public int PropId
        {
            get { return _id; }
            
        }
        public string PropNaam
        {
            get { return _naam}
            set { _naam = value; }
        }
        public List<Persoon> PropPersonen
        {
            get { return _personen; }
            set { _personen = value; }
        }

        //functies en methoden

        //constructors
        public Sport(int ontvId, string ontvNaam, List<Persoon> ontvPersonen)
        {
            _id = ontvId;
            _naam = ontvNaam;
            _personen = ontvPersonen;
        }
    }
}
