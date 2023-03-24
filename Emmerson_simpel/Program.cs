namespace Emmerson_simpel {
    internal class Program {
        static void Main(string[] args) {
            // Erzeugung genau eines Artikels
            Artikel a = new Artikel();
            a.SetBezeichnung("Mein UML-Buch");

            // Erzeugung einer Bestellposition
            BestellPosition bp1 = new BestellPosition();
            bp1.SetArtikel(a);
            bp1.SetMenge(10);

            // Erzeuge Warenkorb mit PositionsListe
            Warenkorb wk = new Warenkorb();
            wk.AddBestellPosition(bp1);

            // Erzeugung eines anderen Artikels
            Artikel b = new Artikel();
            b.SetBezeichnung("Mein C#-Buch");

            // Erzeugung einer Bestellposition
            BestellPosition bp2 = new BestellPosition();
            bp2.SetArtikel(b);
            bp2.SetMenge(100);

            wk.AddBestellPosition(bp2);  // WK - siehe oben
            wk.ZeigMal();

            Console.Read();
        }
    }
}