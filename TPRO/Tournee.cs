using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public class Tournee
    {
        private ListeVilles listeVille;
        public ListeVilles ListeVille { get => this.listeVille; }

        private string nom;

        public Tournee(ListeVilles listeVille,string nom)
        {
            this.listeVille = listeVille;
            this.nom = nom;
        }

        public void ajout(Ville ville)
        {
            this.listeVille.ListVilles.Add(ville);
        }

        

        public override string ToString()
        {
            string s = this.nom + " [";
            for(int i = 0; i < this.listeVille.taille() - 1; i++)
            {
                if (i != 0)
                {
                    s += ", ";
                }
                s += this.listeVille.get(i).Numero;
            }
            s += "]";
            return s;
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

        
    }
}
