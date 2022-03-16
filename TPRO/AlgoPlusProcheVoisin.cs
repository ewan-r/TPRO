using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    class AlgoPlusProcheVoisin : Algo
    {
        public AlgoPlusProcheVoisin(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public override Tournee executer()
        {
            List<Ville> villesNV = this.ListeVilles.ListVilles;
            List<Ville> villesV = new List<Ville>();
            Ville s = villesNV[0];
            villesNV.Remove(s);
            villesV.Add(s);
            while (villesNV.Count != 0)
            {
                Ville suivant = plusProche(s, villesNV);
                villesV.Add(suivant);
                villesNV.Remove(suivant);
                s = suivant;
            }
            ListeVilles LV = new ListeVilles(villesV);
            Tournee t = new Tournee(LV, "Plus Proche Voisin");
            return t;
        }

        private Ville plusProche(Ville s, List<Ville> lv)
        {
            double distance = -1;
            Ville proche = null;
            double distTemp;
            foreach(Ville v in lv)
            {
                distTemp = s.Distance(v);
                if (proche == null)
                {
                    proche = v;
                    distance = distTemp;
                }
                else if (distTemp < distance)
                {
                    distance = distTemp;
                    proche = v;
                }
            }
            return proche;
        }

        
    }
}
