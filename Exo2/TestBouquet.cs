using System;

namespace Exo2
{
    class TestBouquet
    {
        static void Main(string[] args)
        {
            Fleur rose = new Fleur("rose", 2.6);
            Fleur tulipe = new Fleur("tulipe", 0.4);
            Fleur oeillet = new Fleur("oeillet", 1.8);
            
            LotFleurs lotRoses = new LotFleurs (rose, 5);
            LotFleurs lotTulipes = new LotFleurs (tulipe, 7);
            LotFleurs lotOeillet = new LotFleurs (oeillet, 3);
            
            Bouquet b = new Bouquet(lotRoses, lotTulipes, lotOeillet);

            Double prixB = b.Prix();
            Console.WriteLine(b + " : " + prixB + " euros");
            
            Stock magasin = new Stock(rose, tulipe, oeillet);
            Console.WriteLine(magasin);
            magasin.AjouteRose(100);
            magasin.AjouteTulipe(150);
            magasin.AjouteOeillet(200);
            Console.WriteLine(magasin);
            Boolean orderBouquet = magasin.BouquetFaisable(b);
            Console.WriteLine(orderBouquet);
        }
    }
}