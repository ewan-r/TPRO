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

            }
        }

        public Tournee echanger(Tournee t, int i, int j)
        {

        }
    }
}
