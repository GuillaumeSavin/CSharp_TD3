using System;
using System.Reflection;

namespace Exo2
{
    public class Bouquet
    {
        private LotFleurs[] m_lotFleurs = new LotFleurs[3];
        

        public Bouquet(LotFleurs m_LotFleursRoses, LotFleurs m_LotFleursTulipes, LotFleurs m_LotFleursOeillets)
        {
            this.m_lotFleurs[0] = m_LotFleursRoses;
            this.m_lotFleurs[1] = m_LotFleursTulipes;
            this.m_lotFleurs[2] = m_LotFleursOeillets;
        }

        public Double Prix()
        {
            Double res = 0.0;
            
            foreach (var lot in m_lotFleurs)
            {
                res += lot.Fleur.Prix * lot.NombreFleur;
            }

            return res;
        }

        public LotFleurs[] MLotFleurs
        {
            get => m_lotFleurs;
            set => m_lotFleurs = value;
        }
    }
}