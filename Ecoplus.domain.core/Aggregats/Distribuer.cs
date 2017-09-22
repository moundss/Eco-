using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecoplus.domain.core.Aggregats
{
    class Distribuer
    {
        public int Id { get; private set; }
        public DateTime Datedistribuee { get; private set; }
        public float QteDistribuee { get; private set; }
        public int IdExploitant { get; private set; }
        public int IdDepot { get; private set; }

        public Distribuer(int id, DateTime datedistribuee, float qteDistribuee, int idExploitant, int idDepot)
        {
            Id = id;
            Datedistribuee = datedistribuee;
            QteDistribuee = qteDistribuee;
            IdExploitant = idExploitant;
            IdDepot = idDepot;
        }

        public Distribuer Ajout(int id, DateTime datedistribuee, float qteDistribuee, int idExploitant, int idDepot)
            => new Distribuer(id,datedistribuee,qteDistribuee,idExploitant,idDepot);

        public void Modifier(int id, Distribuer distribution)
        {
            if(id!=distribution.Id)return;
            Datedistribuee = distribution.Datedistribuee;
            QteDistribuee = distribution.QteDistribuee;
            IdExploitant = distribution.IdExploitant;
            IdDepot = distribution.IdDepot;

        }
    }
}
