using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAtelier
{
    class Atelier
    {
        protected int ateId;
        protected String ateNom;
        protected String ateDescrpition;
        protected String ateHoraire;
        protected DateTime ateJour;
        protected int ateNbrPlace;
        protected String atePublicConcerne;

        public Atelier(int pateId, String pateNom, String pateDescription, String pateHoraire, DateTime pateJour, int pateNbrPlace, String patePublicConcerne)
        {
            this.ateId = pateId;
            this.ateNom = pateNom;
            this.ateDescrpition = pateDescription;
            this.ateHoraire = pateHoraire;
            this.ateJour = pateJour;
            this.ateNbrPlace = pateNbrPlace;
            this.atePublicConcerne = patePublicConcerne;
        }

        public Atelier()
        {
            this.ateId = 0;
            this.ateNom = "";
            this.ateDescrpition = "";
            this.ateHoraire = "";
            this.ateJour = new DateTime(2019 - 04 - 22);
            this.ateNbrPlace = 0;
            this.atePublicConcerne = "";
        }

        public string GetNom()
        {
            return this.ateNom;
        }

        public int GetId()
        {
            return this.ateId;
        }

        public string GetDescription()
        {
            return this.ateDescrpition;
        }

        public string GetHoraire()
        {
            return this.ateHoraire;
        }

        public DateTime GetJour()
        {
            return this.ateJour;
        }

        public int GetNbrPlace()
        {
            return this.ateNbrPlace;
        }
        public string GetPublicConcerne()
        {
            return this.atePublicConcerne;
        }


        public override String ToString()
        {
            return this.ateNom + " " + this.ateJour + " " + this.ateHoraire;
        }
    }
}
