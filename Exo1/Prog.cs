    
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
            Console.WriteLine(compte1.ToString());
            Console.WriteLine(compte2.ToString());

            Compte[] tabComptes = new Compte[10];
            for (int i = 0; i < tabComptes.Length; i ++)
            {
                tabComptes[i] = new Compte();
            }

            for (int i = 0; i < tabComptes.Length; i ++)
            {
                tabComptes[i].Deposer(200 + 100 * i);
                if (i < tabComptes.Length - 1)
                {
                    
                    tabComptes[i].VirerVers(20, tabComptes[i + 1]);    
                }
                Console.WriteLine(tabComptes[i].ToString());
            }
            
            CompteCourant cc1 = new CompteCourant("Guillaume Savin");
            CompteCourant cc2 = new CompteCourant("Peggy Calderon/Kayser");
            CompteCourant cc3 = new CompteCourant("Kevin");
            cc1.Deposer(500);
            cc2.Deposer(1000000);
            
            Console.WriteLine(cc1.ToString());
            Console.WriteLine(cc2.ToString());
            CollectionComptes ColC = new CollectionComptes(5);
            ColC[0] = cc1;
            ColC[1] = cc2;
            ColC[10] = cc3;
            
            
            Console.WriteLine(ColC[1].ToString());
            Console.WriteLine("test = " + ColC[10]?.ToString());
            Console.WriteLine(ColC[0].ToString());
            Console.WriteLine(ColC.ToString());
            
            CompteEpargne ce1 = new CompteEpargne();
            ce1.Deposer(500);
            Console.WriteLine(ce1.ToString());
            ColC[2] = ce1;
            ColC[3] = compte1;
            ColC.ajout(cc2);
            Console.WriteLine(ColC.ToString());
        }
    }
}