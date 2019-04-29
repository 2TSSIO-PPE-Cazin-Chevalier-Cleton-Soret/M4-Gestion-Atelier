using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAtelier
{
    class Enfant
    {
        protected int enfId;
        protected String enfPrenom;
        protected String enfNom;
        protected String enfNumTelParent;
        protected String enfStatut;
        protected String enfInformations;
        protected DateTime enfDateInscription;
        protected DateTime enfDateFinInscription;

        public Enfant(int penfId, String penfPrenom, String penfNom, String penfNumTelParent, String penfStatut, String penfInformations, DateTime penfDateInscription, DateTime penfDateFinInscription)
        {
            this.enfId = penfId;
            this.enfPrenom = penfPrenom;
            this.enfNom = penfNom;
            this.enfNumTelParent = penfNumTelParent;
            this.enfStatut = penfStatut;
            this.enfInformations = penfInformations;
            this.enfDateInscription = penfDateInscription;
            this.enfDateFinInscription = penfDateFinInscription;
        }

        public Enfant()
        {
            this.enfId = 0;
            this.enfPrenom = null;
            this.enfNom = null;
            this.enfNumTelParent = null;
            this.enfStatut = null;
            this.enfInformations = null;
            this.enfDateInscription = new DateTime(2019 - 04 - 22);
            this.enfDateFinInscription = new DateTime(2019 - 04 - 22);
        }

        public int GetId()
        {
            return this.enfId;
        }

        public string getNom()
        {
            return this.enfNom;
        }

        public override String ToString()
        {
            return this.enfNom + " " + this.enfPrenom + " " + this.enfDateInscription;
        }
    }
}
