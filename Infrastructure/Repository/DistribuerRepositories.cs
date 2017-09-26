using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecoplus.domain.core.Dtos;
using Ecoplus.domain.core.Interfaces.Repository;

namespace Ecoplus.Infrastructure.Repository 
{
    class DistributionRepositories : IDistribution
    {
        public async Task<bool> Enregistrer()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Supprimer()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DistribuerDtos>> ListeDistribution()
        {
            throw new NotImplementedException();
        }
    }
}
