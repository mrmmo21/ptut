﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Metier.Carte.Cases;

namespace Metier.Carte
{
    public interface ICarte
    {
        Case GetCase(Coordonnee coordonnee);
        ICollection<Case> getCases();
    }
}
