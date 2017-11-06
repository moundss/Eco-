using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecoplus.domain.core.Aggregats;
using Ecoplus.domain.core.Dtos;

namespace Ecoplus.domain.core.Interfaces.Repository
{
    public interface IDepotRepositories
    {
        List<DepotDtos> Listedepot();
        //Enregistrer Dépots
        Task<bool> Enregistrer(Depot mondepot);
        //Modifier dépots
        Task<bool> Modifier(int idDepot, Depot monDepot);
        //Supprimer Dépots
        Task<bool> Supprimer(int idDepot);
    }
}