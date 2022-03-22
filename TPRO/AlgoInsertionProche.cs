using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public class AlgoInsertionProche : Algo
    {
        public AlgoInsertionProche(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public override Tournee executer()
        {
            List<Ville> villesNV = this.ListeVilles.ListVilles;
            List<Ville> villesV = new List<Ville>();
            double distance=-1;
            double distanceCalc;
            Ville vi1 = null;
            Ville vi2 = null;
            foreach(Ville v in villesNV)
            {
                foreach(Ville v2 in villesNV)
                {
                    distanceCalc = v.Distance(v2);
                    if(vi1==null && vi2 == null)
                    {
                        vi1 = v;
                        vi2 = v2;
                        distance = distanceCalc;
                    }
                    else if (distanceCalc > distance)
                    {
                        vi1 = v;
                        vi2 = v2;
                    }
                }
            }
            villesV.Add(vi1);
            villesNV.Remove(vi1);
            villesNV.Remove(vi2);
            villesNV.Add(vi2);
            Console.WriteLine(villesNV.Count.ToString());
            int i = 0;
            while (villesNV.Count != 0)
            {
                Ville suivant = PlusProche(villesNV, villesV);
                villesV.Add(suivant);
                villesNV.Remove(suivant);
            }
            ListeVilles LV = new ListeVilles(villesV);
            Tournee t = new Tournee(LV,"insertion proche");
            return t;
        }


        public Ville PlusProche(List<Ville> lnv, List<Ville> lv)
        {
            Ville v = null;
            double dist = -1;
            double distS;
            foreach (Ville v1 in lnv)
            {
                for(int i = 0; i < lv.Count - 1; i++)
                {
                    if (lv[i + 1] != null)
                    {
                        distS = lv[i].Distance(v1) + v1.Distance(lv[i + 1]);
                        if (v == null)
                        {
                            v = v1;
                            dist = distS;
                        }
                        else if (distS < dist)
                        {
                            v = v1;
                            dist = distS;
                        }
                    }
                }
            }
            return v;
        }
    }
}
