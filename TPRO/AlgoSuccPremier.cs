namespace TPRO
{
    public class AlgoSuccPremier : Algo
    {
        public AlgoSuccPremier(ListeVilles listeVilles) : base(listeVilles)
        {
        }

        public Tournee executer(Tournee t)
        {
            Tournee Tcourante = t;
            bool fini = false;
            bool trouve = false;
            while (!fini)
            {
                fini = true;
                Tournee Tvoisin = new Tournee(t);
                for (int i = 0; i < t.ListeVille.taille()&&!trouve; i++)
                {
                    if (Tvoisin.ListeVille.ListVilles.IndexOf(Tvoisin.ListeVille.get(i)) < (Tvoisin.ListeVille.taille() - 1))
                    {
                        Tvoisin.ListeVille.inverser(i, i + 1);

                    }

                }
                if (Tvoisin.cout() < Tcourante.cout())
                {
                    Tcourante = Tvoisin;
                    fini = false;
                    trouve = true;
                }
            }
            return Tcourante;
        }

        public override Tournee executer()
        {
            throw new System.NotImplementedException();
        }

       
    }
}
