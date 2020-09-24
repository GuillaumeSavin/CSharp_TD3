namespace Exo2
{
    public class LotFleurs
    {
        private Fleur fleur;
        private int nombreFleur;

        public LotFleurs(Fleur m_Fleur, int m_NbrFleur)
        {
            this.fleur = m_Fleur;
            this.nombreFleur = m_NbrFleur;
        }

        public Fleur Fleur
        {
            get => fleur;
            set => fleur = value;
        }

        public int NombreFleur
        {
            get => nombreFleur;
            set => nombreFleur = value;
        }
    }
}