using System.Collections.Generic;
using System.Threading.Tasks;
using Ecoplus.domain.core.Dtos;

namespace Ecoplus.domain.core.Interfaces.Repository
{
    public interface IDepotRepositories
    {
        //lister Dépots
        List<IEnumerable<DepotDtos>> Listedepot();
        //Enregistrer Dépots
        Task<bool> Enregistrer();
        //Modifier dépots
        Task<bool> Modifier();
        //Supprimer Dépots
        Task<bool> Supprimer();
    }
}