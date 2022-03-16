using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public abstract class Algo
    {
        private ListeVilles listeVilles;

        public ListeVilles ListeVilles { get => this.listeVilles; }

        public Algo(ListeVilles listeVilles)
        {
            this.listeVilles = listeVilles;
        }

        public abstract Tournee executer();
    }
}
