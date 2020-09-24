using System;

namespace Exo1
{
    public class Compte
    {
        private int solde = 0;

        public void Deposer(int montant)
        {
            solde += montant;
        }

        public void Retirer(int montant)
        {
            solde -= montant;
        }

        public void VirerVers(int montant, Compte destination)
        {
            this.Retirer(montant);
            destination.Deposer(montant);
        }

        public void ToString()
        {
            Console.WriteLine("Affichage Compte :\n\tLe solde est de " + this.solde);
        }
    }
}