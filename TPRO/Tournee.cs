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

        public Tournee(string nom)
        {
            this.listeVille = new ListeVilles();
            this.nom = nom;
        }

        public void ajout(Ville ville)
        {
            this.listeVille.ListVilles.Add(ville);
        }

        public void ajout(Ville v, int index)
        {
            this.listeVille.ListVilles.Insert(index, v);
        }

        

        public override string ToString()
        {
            string s = this.nom + " [";
            for(int i = 0; i < this.listeVille.taille() ; i++)
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

        public void inserVille(Ville v)
        {
            double d = 0;
            double ds;
            int index=0;
            for (int i = 0; i < this.ListeVille.taille() - 1; i++)
            {
                ds = v.Distance(this.ListeVille.get(i), this.ListeVille.get(i + 1));
                if (d == 0)
                {
                    d=ds;
                    index = i + 1;
                }
                else if (ds < d)
                {
                    d=ds;
                    index = i + 1;
                }
            }
            ds = v.Distance(this.ListeVille.get(this.ListeVille.taille() - 1), this.ListeVille.get(0));
            if (ds < d)
            {
                d = ds;
                index = this.ListeVille.taille() + 1;
            }
            if (index >= this.listeVille.taille())
            {
                this.ajout(v);
            }
            else
            {
                this.ajout(v, index);
            }
        }

        
    }
}
