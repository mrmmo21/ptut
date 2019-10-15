using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Carte.Cases
{
    class CaseRecif : Case
    {
        public CaseRecif(bool minerai) : base(minerai)
        {
        }

        public override TypeCases type()
        {
            return TypeCases.RECIF;
        }
    }
}
