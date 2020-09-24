    
using System;

namespace Exo1
{
    class Prog
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte();
            Compte compte2 = new Compte();
            
            compte1.Deposer(500);
            compte2.Deposer(1000);
            compte2.Retirer(10);
            compte1.VirerVers(75, compte2);
            compte1.ToString();
            compte2.ToString();

            Compte[] tabComptes = new Compte[10];

            for (int i = 0; i < tabComptes.Length; i++)
            {
                tabComptes[i].Deposer(200 + 100 * i);
                if (i < (tabComptes.Length - 1))
                {
                    tabComptes[i].VirerVers(20, tabComptes[i + 1]);    
                }
                tabComptes[i].ToString();
                
            }
        }
    }
}