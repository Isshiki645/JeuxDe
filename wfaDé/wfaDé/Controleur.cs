using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaDé
{
    public abstract class Controleur
    {
        private string typeDeDé;
        private int NbFaces;

        protected Controleur(string typeDeDé, int nbFaces)
        {
            TypeDeDé = typeDeDé;
            NbFaces = nbFaces;
        }

        public string TypeDeDé { get => typeDeDé; set => typeDeDé = value; }

        public abstract int Melanger();
    }
}
