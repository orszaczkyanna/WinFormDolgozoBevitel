using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDolgozoBevitel
{
    class Dolgozo
    {
        readonly int id;
        readonly string nev;
        readonly string szulIdo;

        public int Id => id;
        public string Nev => nev;
        public string SzulIdo => szulIdo;

        public Dolgozo(int id, string nev, string szulIdo)
        {
            this.id = id;
            this.nev = nev;
            this.szulIdo = szulIdo;
        }

        public override string ToString()
        {
            return $"{id} {nev} ({szulIdo})";
        }

    }
}
