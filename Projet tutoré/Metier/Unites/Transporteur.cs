using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    public abstract class Transporteur : Unite
    {



        private int capacite;

        public Transporteur(Case position) : base(position)
        {

        }

        public int Capacité
        {
            get => capacite;
            set => capacite = value;
        }

    }
}
