using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Carte.Cases
{
    public class Tab<Case> : ICollection<Case>
    {
        ICollection<Case> cases;

        public Tab()
        {
            cases = new Collection<Case>();
        }

        public int Count => cases.Count;

        public bool IsReadOnly => cases.IsReadOnly;

        public void Add(Case item)
        {
            cases.Add(item);
        }

        public void Clear()
        {
            cases.Clear();
        }

        public bool Contains(Case item)
        {
            return cases.Contains(item);
        }

        public void CopyTo(Case[] array, int arrayIndex)
        {
            cases.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Case> GetEnumerator()
        {
            return cases.GetEnumerator();
        }

        public bool Remove(Case item)
        {
            return cases.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cases.GetEnumerator();
        }
    }
}
