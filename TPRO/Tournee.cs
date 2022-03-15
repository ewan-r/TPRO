using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    class Tournee
    {
        private ListeVilles listeVille;
        public ListeVilles LusteVille { get => this.listeVille; }

        public Tournee(ListeVilles listeVille)
        {
            this.listeVille = listeVille;
        }

        public void ajout(Ville ville)
        {
            this.listeVille.ListVilles.Add(ville);
        }

        public void afficheTour()
        {
            string s = "tournée croissante [";
            for(int i = 0; i < this.listeVille.taille(); i++)
            {
                if (i != 0)
                {
                    s += ",";
                }
                s += this.listeVille.get(i).Numero;
            }
            s += "]";
            Console.WriteLine(s);
        }

        public double cout()
        {
            double c = 0;
            for(int i = 0; i < this.listeVille.taille()-1; i++)
            {
                c += this.listeVille.get(i).Distance(this.listeVille.get(i + 1));
            }
            c += this.listeVille.get(this.listeVille.taille() - 1).Distance(this.listeVille.get(0));
            return c;
        }

        public Tournee tourAleatoire()
        {
            ListeVilles villesAlea = new ListeVilles(this.listeVille);
            int n = villesAlea.taille();
            Random r = new Random();
            int i;
            while (n > 1)
            {
                n--;
                i = r.Next(n + 1);
                villesAlea.inverser(i,n);
            }
            return new Tournee(villesAlea);
        }
    }
}
