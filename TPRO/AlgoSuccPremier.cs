using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public class AlgoSuccPremier : AlgoRechercheLocal
    {
        public AlgoSuccPremier(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public override Tournee explorerVoisinage(Tournee t)
        {
            Tournee Tvoisin = t;
            for (int i = 0; i < t.ListeVille.taille(); i++)
            {
                if (t.ListeVille.ListVilles.IndexOf(t.ListeVille.get(i)) < (t.ListeVille.taille() - 1))
                {
                    t.ListeVille.inverser(i, i + 1);
                }
            }
            return t;
        }

        
    }
}
