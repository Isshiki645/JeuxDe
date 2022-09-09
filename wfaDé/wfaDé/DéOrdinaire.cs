using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaDé
{
    public class DéOrdinaire : Controleur
    {
        private int nombreObtenue;
        Random random = new Random();
        public DéOrdinaire(string typeDeDé, int nbFaces) : base(typeDeDé, nbFaces)
        {
            typeDeDé = "Ordinaire";
        }

        public int NombreObtenue { get => nombreObtenue; set => nombreObtenue = value; }

        public override int Melanger()
        {
            nombreObtenue = random.Next(1, 7);
            return nombreObtenue;
        }
    }
}
