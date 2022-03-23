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
            bool trouve = false;
            while (!fini)
            {
                fini = true;
                Tournee Tvoisin = explorerVoisinage(Tcourante);
                Console.WriteLine(Tvoisin.cout().ToString());
                Console.WriteLine(Tcourante.cout().ToString());
                if (Tvoisin.cout() < Tcourante.cout())
                {
                    Tcourante = Tvoisin;
                    fini = false;
                    trouve = true;
                }
            }
            return Tcourante;
        }

        public abstract Tournee explorerVoisinage(Tournee t);
    }
}
