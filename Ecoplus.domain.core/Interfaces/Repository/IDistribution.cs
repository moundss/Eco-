using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecoplus.domain.core.Aggregats;
using Ecoplus.domain.core.Dtos;

namespace Ecoplus.domain.core.Interfaces.Repository
{
    public interface IDistribution
    {
        //Enregister une distribution
        Task<bool> Enregistrer(Distribuer madist);
        //Modifier une distribution
        Task<bool> Supprimer(int idDist);
        //Modifier la distribution
        Task<bool> Modifier(int idDist, Distribuer madist);
            //Lister les Distribution
        Task<IEnumerable<DistribuerDtos>> ListeDistribution();
    }
}