using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    class Barge : Transporteur
    {

        public Barge(Case position) : base(position)
        {
            this.Capacité = 4;
        }

        public override TypeUnite Type()
        {
            return TypeUnite.BARGE;
        }
    }
}
