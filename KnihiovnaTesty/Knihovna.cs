using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihiovnaTesty
{
   public class Knihovna
    {
        public Kniha[] PoleKnih;
        public Navstevnik[] PoleNavstevniku;
        private int posledniIndexKnih;
        private int posledniIndexNavstevniku;

        public Knihovna(int velikostPoleKnih, int velikostPoleNavstevniku)
        {
            PoleKnih = new Kniha[velikostPoleKnih];
            PoleNavstevniku = new Navstevnik[velikostPoleNavstevniku];
            posledniIndexKnih = 0;
            posledniIndexNavstevniku = 0;
        }

        public void PridejKnihu(Kniha kniha)
        {
            if (posledniIndexKnih < PoleKnih.Length)
            {
                PoleKnih[posledniIndexKnih] = kniha;
                posledniIndexKnih++;
            }
            else
                Console.WriteLine("Knihovna je plná.");
        }

        public void PridejNavstevnika(Navstevnik navstevnik)
        {
            if (posledniIndexNavstevniku < PoleNavstevniku.Length)
            {
                PoleNavstevniku[posledniIndexNavstevniku] = navstevnik;
                posledniIndexNavstevniku++;
            }
            else
                Console.WriteLine("Knihovna má moc návštěvníků.");
        }

        public void VypujcKnihu(Navstevnik navstevnik, Kniha kniha)
        {
            for (int i = 0; i < navstevnik.PoleZapujcenychKnih.Length; i++)
            {
                if (navstevnik.PoleZapujcenychKnih[i] == null)
                {
                    navstevnik.PoleZapujcenychKnih[i] = kniha;
                    kniha.JeVypujcena = true;
                    Console.WriteLine($"Půjčil sis knihu {kniha.Nazev}");
                    return;
                }
            }
            Console.WriteLine("Máte maximální počet knih, které si můžete půjčit najednou.");
        }

        public void NavratKnihu(Navstevnik navstevnik, Kniha kniha)
        {
            for (int i = 0; i < navstevnik.PoleZapujcenychKnih.Length; i++)
            {
                if (navstevnik.PoleZapujcenychKnih[i] == kniha)
                {
                    navstevnik.PoleZapujcenychKnih[i] = null;
                    kniha.JeVypujcena = false;
                    Console.WriteLine("Kniha vrácena úspěšně.");
                    return;
                }
            }
            Console.WriteLine("Tato kniha není v seznamu vašich zapůjčených knih.");
        }
    }
}
