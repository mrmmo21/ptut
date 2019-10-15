using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Carte.Cases
{
    public abstract class Case : ICase
    {

        public Case(bool minerai)
        {
            this.Minerai = minerai;
        }

        private bool minerai;
        private bool ponton;

        public bool Minerai
        {
            get => minerai;
            set => minerai = value;
        }

        public bool Ponton
        {
            get => ponton;
            set => ponton = value;
        }
        
        public abstract TypeCases type();

        public ICollection<Case> voisins()
        {
            throw new NotImplementedException();
        }
    }
}
