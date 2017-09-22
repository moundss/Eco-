using System;

namespace Ecoplus.domain.core.Dtos
{
    public class DistribuerDtos
    {
        public int Id { get; }
        public DateTime Datedistribuee { get;  }
        public float QteDistribuee { get; }
        public int IdExploitant { get; }
        public int IdDepot { get; }

        public DistribuerDtos(int id, DateTime datedistribuee, float qteDistribuee, int idExploitant, int idDepot)
        {
            Id = id;
            Datedistribuee = datedistribuee;
            QteDistribuee = qteDistribuee;
            IdExploitant = idExploitant;
            IdDepot = idDepot;
        }
    }
}