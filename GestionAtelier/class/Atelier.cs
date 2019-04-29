using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GestionActivitePlanificateur
{

    class Atelier
    {
        protected String ateNom;
        protected String ateDescrpition;
        protected String ateHoraire;
        protected int ateNbrPlace;
        protected String atePublicConcerne;

        public Atelier(String pateNom, String pateDescription, String pateHoraire, int pateNbrPlace, String patePublicConcerne)
        {
            this.ateNom = pateNom;
            this.ateDescrpition = pateDescription;
            this.ateHoraire = pateHoraire;
            this.ateNbrPlace = pateNbrPlace;
            this.atePublicConcerne = patePublicConcerne;
        }

        public string getNom()
        {
            return this.ateNom;
        }

    }
}
