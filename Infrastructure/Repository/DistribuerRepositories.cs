using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Ecoplus.domain.core.Aggregats;
using Ecoplus.domain.core.Dtos;
using Ecoplus.domain.core.Interfaces.Repository;

namespace Ecoplus.Infrastructure.Repository 
{
    class DistributionRepositories : IDistribution
    {
        private readonly string _strcnx = ConfigurationManager.ConnectionStrings["Database:Ecoplus"].ConnectionString;
        public async Task<bool> Enregistrer(Distribuer madist)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                var param=new DynamicParameters();
                param.Add("@Id_dist",madist.Id);
                param.Add("@qte_distribuer",madist.QteDistribuee);
                param.Add("@dateDistribuer",madist.Datedistribuee);
                param.Add("@id_exploitant",madist.IdExploitant);
                param.Add("@id_depot",madist.IdDepot);
                cnx.Open();
                var result =await cnx.ExecuteAsync("Insert_distribution", param, commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result>0;
            }
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DistribuerDtos>> ListeDistribution()
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                cnx.Open();
                var result = await cnx.QueryAsync<DistribuerDtos>("Select_distribution",
                    commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result;
            }
            throw new NotImplementedException();
        }

        public async Task<bool> Supprimer(int idDist)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                cnx.Open();
                var param = new DynamicParameters();
                param.Add("@Id_dist",idDist);
                var result = await cnx.ExecuteAsync("Delete_Distribution", param,
                    commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result > 0;
            }
            throw new NotImplementedException();
        }

        public async Task<bool> Modifier(int idDist, Distribuer madist)
        {
            using (var cnx = new SqlConnection(_strcnx))
            {
                var param = new DynamicParameters();
                param.Add("@Id_dist", madist.Id);
                param.Add("@qte_distribuer", madist.QteDistribuee);
                param.Add("@dateDistribuer", madist.Datedistribuee);
                param.Add("@id_exploitant", madist.IdExploitant);
                param.Add("@id_depot", madist.IdDepot);
                cnx.Open();
                var result = await cnx.ExecuteAsync("Update_Distribution", param,
                    commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result > 0;
            }
            throw new NotImplementedException();
        }
    }
}
