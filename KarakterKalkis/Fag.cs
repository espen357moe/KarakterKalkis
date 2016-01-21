using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterKalkis
{
    public enum LovligKarakter { A = 5, B = 4, C = 3, D = 2, E = 1, F = 0 };

    class Fag //Et fag består av et vekttall som er enten 7.5 eller 15, og en bokstavkarakter som korresponderer med en heltallsverdi
    {        
        private LovligKarakter _karakter;
        private float _vekttall;

        public char BokstavKarakter
        {
            get { return _karakter.ToString().First(); }
            set { _karakter = (LovligKarakter)Enum.Parse(typeof(LovligKarakter), value.ToString()); }        
        }

        public float Vekttall
        {
            get { return this._vekttall; }
            set { this._vekttall = value; }
        }
    }
}
