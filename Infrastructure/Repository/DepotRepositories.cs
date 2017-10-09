using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Ecoplus.domain.core.Dtos;
using Ecoplus.domain.core.Interfaces.Repository;
using System.Configuration;
using Dapper;
using DapperExtensions;
using Ecoplus.domain.core.Aggregats;

namespace Ecoplus.Infrastructure.Repository
{
    
    public class DepotRepositories : IDepotRepositories
    {
        private readonly string _strcnx = ConfigurationManager.ConnectionStrings["Database:Ecoplus"].ConnectionString;
        public List<IEnumerable<DepotDtos>> Listedepot()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Enregistrer(Depot mondepot)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                cnx.Open();
                var result= await cnx.InsertAsync(mondepot);
                cnx.Close();
                return result;
            }
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
