using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    public abstract class Unite : IUnite
    {

        public Unite(Case position)
        {
            this.Position = position;
        }

        private Case position;

        private int joueur;

        public int Joueur
        {
            get => joueur;
            set => joueur = value;
        }

        public Case Position
        {
            get => position;
            set => position = value;
        }

        public abstract TypeUnite Type();
            
    }
}
