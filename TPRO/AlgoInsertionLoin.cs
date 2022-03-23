using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public class AlgoInsertionLoin : Algo
    {
        public AlgoInsertionLoin(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public override Tournee executer()
        {
            List<Ville> villesNV = this.ListeVilles.ListVilles;
            double distance = -1;
            double distanceCalc;
            Ville vi1 = null;
            Ville vi2 = null;
            foreach (Ville v in villesNV)
            {
                foreach (Ville v2 in villesNV)
                {
                    distanceCalc = v.Distance(v2);
                    if (vi1 == null && vi2 == null)
                    {
                        vi1 = v;
                        vi2 = v2;
                        distance = distanceCalc;
                    }
                    else if (distanceCalc > distance)
                    {
                        vi1 = v;
                        vi2 = v2;
                        distance = distanceCalc;
                    }
                }
            }
            Tournee t = new Tournee("insertion loin");
            t.ajout(vi1);
            t.ajout(vi2);
            villesNV.Remove(vi1);
            villesNV.Remove(vi2);


            while (villesNV.Count != 0)
            {
                distance = -1;
                Ville suivant = null;
                foreach (Ville v in villesNV)
                {
                    distanceCalc = v.DistanceMax(t);
                    if (suivant == null)
                    {
                        suivant = v;
                        distance = distanceCalc;
                    }
                    else if (distanceCalc > distance)
                    {
                        suivant = v;
                        distance = distanceCalc;
                    }
                }

                villesNV.Remove(suivant);
                t.inserVilleMax(suivant);
            }
            return t;
        }
    }
}
