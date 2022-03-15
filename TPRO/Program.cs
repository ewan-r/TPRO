using System;
using System.IO;

namespace TPRO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fichier = ReadFile("../../../../instances/top80.txt");
            ListeVilles villes = new ListeVilles(fichier);
            double dist = villes.get(0).Distance(villes.get(1));
            //Console.WriteLine(dist);
            Tournee tour = new Tournee(villes);
            //tour.afficheTour();
            //Console.WriteLine(tour.cout());
            Tournee tournAlea = tour.tourAleatoire();
            tournAlea.afficheTour();
        }

        public static string[] ReadFile (string fichier)
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
