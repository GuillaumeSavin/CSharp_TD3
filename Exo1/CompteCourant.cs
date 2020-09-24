using System;

namespace Exo1
{
    public class CompteCourant : Compte
    {
        private String nom;

        public CompteCourant(String m_Nom)
        {
            this.nom = m_Nom;
        }

        public override string ToString()
        {
            String str = base.ToString();

            str += "\n\tNom du titulaire du Compte Courant : " + this.nom;
            return str;
        }
    }
}