using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecoplus.domain.core.Aggregats;
using Ecoplus.domain.core.Dtos;

namespace Ecoplus.domain.core.Interfaces.Repository
{
    public interface IDepotRepositories
    {
        //lister Dépots
        Task<IEnumerable<DepotDtos>> Listedepot();
        //Enregistrer Dépots
        Task<bool> Enregistrer(Depot mondepot);
        //Modifier dépots
        Task<bool> Modifier(Guid idDepot, Depot monDepot);
        //Supprimer Dépots
        Task<bool> Supprimer(Guid idDepot);
    }
}