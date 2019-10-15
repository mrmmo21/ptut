using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Carte.Cases
{
    class CasePlaine : Case
    {
        public CasePlaine(bool minerai) : base(minerai)
        {
        }

        public override TypeCases type()
        {
            return TypeCases.PLAINE;
        }
    }
}
