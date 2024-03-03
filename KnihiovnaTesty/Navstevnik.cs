using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihiovnaTesty
{
    public class Navstevnik
    {

        public string Jmeno;
        public string Prijmeni;
        public int IdentifikacniCislo;
        public Kniha[] PoleZapujcenychKnih;

        public Navstevnik(string jmeno, string prijmeni, int identifikacniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            IdentifikacniCislo = identifikacniCislo;
            PoleZapujcenychKnih = new Kniha[3]; // Předpokládáme, že návštěvník může mít maximálně 3 knihy zapůjčené najednou.
        }
        public void VypisVypujceneKnihy()
        {
            Console.WriteLine($"Vypůjčené knihy pro {Jmeno} {Prijmeni}:");
            foreach (Kniha kniha in PoleZapujcenychKnih)
            {
                if (kniha != null)
                {
                    Console.WriteLine($"- {kniha.Nazev}, rok vydání: {kniha.RokVydani}");
                }
            }
        }
    }
}
