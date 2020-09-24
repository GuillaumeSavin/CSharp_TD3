using System;

namespace Exo1
{
    public class Compte
    {
        private int solde = 0;

        public Compte()
        {
            this.solde = 0;
        }

        public virtual void Deposer(int montant)
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

        public virtual String ToString()
        {
            String str = "Affichage Compte :\n\tLe solde est de " + this.solde;
            return str;
        }
    }
    
    public class CollectionComptes
    {
        private Compte[] m_Comptes;
        private int m_NbElt;
        private int m_Max;

        public CollectionComptes(int Max)
        {
            this.m_Max = Max;
            this.m_NbElt = 0;
            this.m_Comptes = new Compte[Max];
        }

        public Compte this[int i]
        {
            get
            {
                if (i > this.m_NbElt)
                {
                    return null;
                }

                return this.m_Comptes[i];
            }

            set
            {
                if (i < this.m_NbElt)
                {
                    this.m_Comptes[i] = value;
                }

                if (((i + 1) > this.m_NbElt) && (i < this.m_Max))
                {
                    this.m_NbElt++;
                    this.m_Comptes[i] = value;
                }
            }
        }

        public void ajout(Compte m_Compte)
        {
            if (this.m_NbElt < this.m_Max)
            {
                this.m_NbElt++;
                this.m_Comptes[this.m_NbElt] = m_Compte;
            }
            else
            {
                Console.WriteLine("Complet");
            }
        }

        public override string ToString()
        {
            String str = "Affichage CollectionCompte :\n";

            for(int i = 0; i < this.m_NbElt; i ++)
            {
                str += "\t" + this[i].ToString();
                str += "\n";
            }
            
            return str;
        }
    }
}