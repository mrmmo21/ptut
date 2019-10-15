using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Carte.Cases
{
    public class CaseMontagne : Case
    {
        public CaseMontagne(bool minerai) : base(minerai)
        {
        }

        public override TypeCases type()
        {
            return TypeCases.MONTAGNE;
        }
    }
}
}
