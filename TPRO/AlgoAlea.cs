using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public class AlgoAlea : Algo
    {
        public AlgoAlea(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public override Tournee executer()
        {
            ListeVilles villesAlea = new ListeVilles(this.ListeVilles);
            int n = villesAlea.taille();
            Random r = new Random();
            int i;
            while (n > 1)
            {
                n--;
                i = r.Next(n + 1);
                villesAlea.inverser(i, n);
            }
            Tournee t = new Tournee(villesAlea, "Alea");
            return t;
        }
    }
}
