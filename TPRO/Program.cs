using System;
using System.IO;

namespace TPRO
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] fichier = LireFichier("../../../../instances/top80.txt");
            ListeVilles villes = new ListeVilles(fichier);
            //double dist = villes.get(0).Distance(villes.get(1));
            /*AlgoCroissant aC = new AlgoCroissant(villes);
            Tournee tC = aC.executer();
            Console.WriteLine(tC.ToString());
            Console.WriteLine(tC.cout());
            AlgoAlea aA = new AlgoAlea(villes);
            Tournee tA = aA.executer();
            Console.WriteLine(tA.ToString());
            Console.WriteLine(tA.cout());*/
            AlgoPlusProcheVoisin aPPV = new AlgoPlusProcheVoisin(villes);
            Tournee tPPV = aPPV.executer();
            Console.WriteLine(tPPV.ToString());
            Console.WriteLine(tPPV.cout());
            /*AlgoInsertionProche aIP = new AlgoInsertionProche(villes);
            Tournee tIP = aIP.executer();
            Console.WriteLine(tIP.ToString());
            Console.WriteLine(tIP.cout());

            AlgoInsertionLoin aIL = new AlgoInsertionLoin(villes);
            Tournee tIL = aIL.executer();
            Console.WriteLine(tIL.ToString());
            Console.WriteLine(tIL.cout());*/

            AlgoSuccPremier aSP = new AlgoSuccPremier(villes);
            Tournee tSP = new Tournee(villes, "test");
            tSP = aSP.executer(tPPV);
            Console.WriteLine(tSP.ToString());
            Console.WriteLine(tSP.cout());
        }

        public static string[] LireFichier (string fichier)
        {
            string[] ligne = null;
            try
            {
                using (StreamReader reader = new StreamReader(fichier))
                {
                    string contenu = reader.ReadToEnd();
                    ligne = contenu.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ligne;
        }
    }
}
