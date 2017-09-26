using System.Collections.Generic;
using System.Threading.Tasks;
using Ecoplus.domain.core.Dtos;

namespace Ecoplus.domain.core.Interfaces.Repository
{
    public interface IDistribution
    {
        //Enregister une distribution
        Task<bool> Enregistrer();
        //Modifier une distribution
        Task<bool> Supprimer();
        //Lister les Distribution
        Task<IEnumerable<DistribuerDtos>> ListeDistribution();
    }
}