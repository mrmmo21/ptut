using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    class Tourelle : Destructeur
    {

        public Tourelle(Case position) : base(position)
        {

        }

        public override TypeUnite Type()
        {
            return TypeUnite.TOURELLE;
        }
    }
}
