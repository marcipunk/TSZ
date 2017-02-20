using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSZ
{
    enum Fajta { Holstein_fríz, Jersey, Ayrshire, Magyartarka}

    class Tehen
    {
        private int id;
        private string nev;
        private int tejhozam;
        private Fajta fajta;

        public Tehen(string name, int tejhozam, Fajta fajta)
        {
            this.id = TehenData.tehenTable.Rows.Count + 1;
            this.nev = name;
            this.tejhozam = tejhozam;
            this.fajta = fajta;
        }
    }
}
