using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    class Pondeuse : Transporteur
    {
        public Pondeuse(Case position)
        {
            this.Capacité = 1;
            this.Position = position;
        }

        public override TypeUnite Type()
        {
            return TypeUnite.PONDEUSE;
        }
    }
}
