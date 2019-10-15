using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    class Astronef : Unite
    {
        Collection<Tourelle> tour;

        public Astronef(Case position) : base(position)
        {
            tour = new Collection<Tourelle>();
        }

        public override TypeUnite Type()
        {
            return TypeUnite.ASTRONEF;
        }
    }
}
