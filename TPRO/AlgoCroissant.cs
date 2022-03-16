using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public class AlgoCroissant : Algo
    {
        public AlgoCroissant(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public override Tournee executer()
        {
            Tournee t = new Tournee(ListeVilles,"croissant");
            return t;
        }
    }
}
