using System.Collections.Generic;
using System.Threading.Tasks;
using Ecoplus.domain.core.Dtos;
using Ecoplus.domain.core.Interfaces.Repository;

namespace Ecoplus.Infrastructure.Repository
{
    
    public class DepotRepositories : IDepotRepositories
    {
        public List<IEnumerable<DepotDtos>> Listedepot()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Enregistrer()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Modifier()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Supprimer()
        {
            throw new System.NotImplementedException();
        }
    }
}
