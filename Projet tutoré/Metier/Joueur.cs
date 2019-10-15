using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier.Carte;

namespace Metier
{
    class Joueur
    {
        private int action;
        private bool IA;
        private int aggresivite;
        private Map carte;

        public Joueur(bool iA, int aggresivite, Map carte)
        {
            this.IA = iA;
            this.aggresivite = aggresivite;
            this.carte = carte;
        }


    }
}
