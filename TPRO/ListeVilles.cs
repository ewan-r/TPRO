using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TPRO
{
    public class ListeVilles
    {
        private string[] villesTab;
        private List<Ville> listVilles = new List<Ville>();
        public List<Ville> ListVilles { get => this.listVilles; }

        public ListeVilles(string[] villesTab)
        {
            this.villesTab = villesTab;
            foreach (string line in this.villesTab)
            {
                string[] ligne = line.Split(" ");
                int numero = int.Parse(ligne[0]);
                string nom = ligne[1];
                double latitude = double.Parse(ligne[2], CultureInfo.InvariantCulture);
                double longitude = double.Parse(ligne[3], CultureInfo.InvariantCulture);
                Ville ville = new Ville(numero, nom, latitude, longitude);
                this.listVilles.Add(ville);
            }
        }

        public ListeVilles()
        {
            this.listVilles = new List<Ville>();
        }

        public ListeVilles(List<Ville> lv)
        {
            this.listVilles = new List<Ville>(lv);
        }

        public ListeVilles(ListeVilles villes)
        {
            this.listVilles = new List<Ville>(villes.ListVilles);
        }

        public Ville get(int i)
        {
            return this.ListVilles[i];
        }

        public override string ToString()
        {
            string s = "";
            foreach(Ville v in this.listVilles)
            {
                s += v.Numero + " " + v.Nom + " " + v.Longitude + " " + v.Latitude + "\n";
            }
            return s;
        }

        public int taille()
        {
            return this.listVilles.Count;
        }

        public void inverser(int i, int j)
        {
            Ville sauv = listVilles[i];
            listVilles[i] = listVilles[j];
            listVilles[j] = sauv;
        }
    }
}
