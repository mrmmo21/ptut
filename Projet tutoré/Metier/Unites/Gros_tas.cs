using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    class Gros_Tas : Destructeur
    {
        public Gros_Tas(Case position) : base(position)
        {

        }

        public override TypeUnite Type()
        {
            return TypeUnite.GROS_TAS;
        }
    }
}
