using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaDé
{
    public class DéPipe : Controleur
    {
        private int nombreRésultat;
        Random randomChance = new Random();
        Random random = new Random();
        public DéPipe(string typeDeDé, int nbFaces) : base(typeDeDé, nbFaces)
        {
            typeDeDé = "Pipe";
        }

        public int NombreRésultat { get => nombreRésultat; set => nombreRésultat = value; }

        public override int Melanger()
        {
            int chance = randomChance.Next(1, 101);

            if (chance <= 75)
            {
                nombreRésultat = random.Next(3, 7);
                return nombreRésultat;
            }
            else
            {
                nombreRésultat = random.Next(1, 7);
                return nombreRésultat;
            }
        }
    }
}
