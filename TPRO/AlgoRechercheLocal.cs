using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public abstract class AlgoRechercheLocal : Algo
    {
        public AlgoRechercheLocal(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public override Tournee executer()
        {
            throw new NotImplementedException();
        }

        public Tournee executer(Tournee t)
        {
            Tournee Tcourante = t;
            bool fini = false;
            while (!fini)
            {
                fini = true;
                Tournee Tvoisin = explorerVoisinage(Tcourante);
                if (Tvoisin.cout() < Tcourante.cout())
                {
                    Tcourante = Tvoisin;
                    fini = false;
                }
            }
            return Tcourante;
        }

        public abstract Tournee explorerVoisinage(Tournee t);
    }
}
