using System;

namespace Exo2
{
    public class Stock
    {
        private Fleur[] mFleurs = new Fleur[3];
        private int nombreRose;
        private int nombreTulipe;
        private int nombreOeillet;
        public Stock(Fleur p_Rose, Fleur p_Tulipe, Fleur p_Oeillet)
        {
            this.mFleurs[0] = p_Rose;
            this.mFleurs[1] = p_Tulipe;
            this.mFleurs[2] = p_Oeillet;
            this.nombreRose = 0;
            this.nombreTulipe = 0;
            this.nombreOeillet = 0;
        }

        public void AjouteRose(int p_nbr)
        {
            this.nombreRose += p_nbr;
        }
        public void AjouteTulipe(int p_nbr)
        {
            this.nombreTulipe += p_nbr;
        } 
        public void AjouteOeillet(int p_nbr)
        {
            this.nombreOeillet += p_nbr;
        }

        public override string ToString()
        {
            String str;
            
            str = "Etat Stock :\n\tNombre de rose: " + this.nombreRose + "\n\tNombre de tulipe: " + this.nombreTulipe + "\n\tNombre d'oeillet: " + this.nombreOeillet;

            return str;
        }

        public Boolean BouquetFaisable(Bouquet p_Bouquet)
        {
            if (p_Bouquet.MLotFleurs[0].NombreFleur <= this.nombreRose && p_Bouquet.MLotFleurs[1].NombreFleur <= this.nombreOeillet && p_Bouquet.MLotFleurs[2].NombreFleur <= this.nombreOeillet)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}