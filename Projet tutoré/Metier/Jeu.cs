using Metier.Carte;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Jeu
    {
        private int tour = 1;
        private Map carte;
        private Collection<Joueur> joueurs;

        public Jeu()
        {
            carte = new Map();
            joueurs = new Collection<Joueur>();
        }
    }
}
