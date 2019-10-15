using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Carte.Cases
{
    class CaseMer : Case
    {
        public CaseMer(bool minerai) : base(minerai)
        {
        }

        public override TypeCases type()
        {
            return TypeCases.MER;
        }
    }
}
