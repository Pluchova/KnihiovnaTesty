using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihiovnaTesty
{
    public class Kniha
    {
        public string Nazev;
        public Autor Autor;
        public int RokVydani;
        public bool JeVypujcena;

        public Kniha(string nazev, Autor autor, int rokVydani, bool jeVypujcena)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;
            JeVypujcena = jeVypujcena;
        }
    }
}
