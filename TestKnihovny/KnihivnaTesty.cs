using KnihiovnaTesty;

namespace TestKnihovny
{
    public class KnihivnaTesty
    {
        [Fact]
        public void VypujcKnihu()
        {
            // Arrange
            Knihovna knihovna = new Knihovna(100, 100);

            Autor autor = new Autor("Karel", "Èapek", 1890);

            Kniha kniha = new Kniha("R.U.R.", autor, 1920, false);
            Kniha kniha2 = new Kniha("Bílá nemoc", autor, 1937, false);
            Navstevnik navstevnik = new Navstevnik("Jan", "Novák", 12345);

            // Act
            knihovna.VypujcKnihu(navstevnik, kniha);

            // Assert
            Assert.True(kniha.JeVypujcena);
            Assert.Contains(kniha, navstevnik.PoleZapujcenychKnih);
        }

        [Fact]
        public void NavratKnihu()
        {
            // Arrange
            Knihovna knihovna = new Knihovna(100, 100);

            Autor autor = new Autor("Karel", "Èapek", 1890);

            Kniha kniha = new Kniha("R.U.R.", autor, 1920, false);
            Kniha kniha2 = new Kniha("Bílá nemoc", autor, 1937, false);
            Navstevnik navstevnik = new Navstevnik("Jan", "Novák", 12345);
           
            
            knihovna.VypujcKnihu(navstevnik, kniha2);
            // Act
            knihovna.NavratKnihu(navstevnik, kniha2);
            
            // Assert
            Assert.False(kniha2.JeVypujcena);
            Assert.DoesNotContain(kniha2, navstevnik.PoleZapujcenychKnih);
        }
    }
}