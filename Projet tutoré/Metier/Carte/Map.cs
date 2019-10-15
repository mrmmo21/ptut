using Metier.Carte.Cases;
using Metier.Unites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Carte
{
    public class Map : ICarte

    {
        private Dictionary<Coordonnee,Case> cases;
        private Collection<Unite> unites;


        public Map()
        {
            cases = new Dictionary<Coordonnee, Case>();
            unites = new Collection<Unite>();
        }


        public Case GetCase(Coordonnee coordonnee)
        {
            this.cases.TryGetValue(coordonnee, out Case c);
            return c;
        }

        public ICollection<Case> getCases()
        {
            return this.cases.Values;
        }
    }
}
