using System;

namespace Exo2
{
    public class Fleur
    {
        private String nom;
        private Double prix;

        public Fleur(String m_Nom, Double m_Prix)
        {
            this.nom = m_Nom;
            this.prix = m_Prix;
        }

        public Double Prix
        {
            get => prix;
            set => prix = value;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }
    }
}