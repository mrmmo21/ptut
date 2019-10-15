﻿using Metier.Carte.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Unites
{
    class Vedette : Destructeur
    {

        public Vedette(Case position) : base(position)
        {

        }

        public override TypeUnite Type()
        {
            return TypeUnite.VEDETTE;
        }
    }
}
