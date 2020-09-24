using System;

namespace Exo1
{
    public class CompteEpargne : Compte
    {
        public override void Deposer(int montant)
        {
            int res;
            res = Convert.ToInt32(montant * 1.02);
            base.Deposer(res);
        }

        public override string ToString()
        {
            String str = base.ToString();

            str += " Info Compte Epargne";
            return str;
        }
    }
}