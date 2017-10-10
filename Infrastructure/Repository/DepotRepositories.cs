using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Ecoplus.domain.core.Dtos;
using Ecoplus.domain.core.Interfaces.Repository;
using System.Configuration;
using System.Data;
using Dapper;
using Ecoplus.domain.core.Aggregats;
using System;

namespace Ecoplus.Infrastructure.Repository
{
    
    public class DepotRepositories : IDepotRepositories
    {
        private readonly string _strcnx = ConfigurationManager.ConnectionStrings["Database:Ecoplus"].ConnectionString;
        public async Task<IEnumerable<DepotDtos>> Listedepot()
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                cnx.Open();
                var result = await cnx.QueryAsync<DepotDtos>("Select_depot",commandType:CommandType.StoredProcedure);
                cnx.Close();
                return result;
            }
            throw new System.NotImplementedException();
        }

        public async Task<bool> Enregistrer(Depot mondepot)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                cnx.Open();
                var param=new DynamicParameters();
                param.Add("@id",mondepot.Id);
                param.Add("@libelle",mondepot.Libelle);
                param.Add("@Qte_stocke",mondepot.Qte);
                param.Add("@Qte_limite",mondepot.Qtelimit);
                param.Add("@localisation",mondepot.Localisation);
                var result = await cnx.ExecuteAsync("Insert_depots",param,commandType:CommandType.StoredProcedure);
                cnx.Close();
                return result>0;
            }
            throw new System.NotImplementedException();
        }

        public async Task<bool> Supprimer(Guid idDepot)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                var param=new DynamicParameters();
                param.Add("@idDepot",idDepot);
                cnx.Open();
                var result =await cnx.ExecuteAsync("Delete_depot", param, commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result > 0;
            }
            throw new System.NotImplementedException();
        }

        public async Task<bool> Modifier(Guid idDepot,Depot monDepot)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                var param=new DynamicParameters();
                param.Add("@id", monDepot.Id);
                param.Add("@libelle", monDepot.Libelle);
                param.Add("@Qte_stocke", monDepot.Qte);
                param.Add("@Qte_limite", monDepot.Qtelimit);
                param.Add("@localisation", monDepot.Localisation);
                cnx.Open();
                var result = await cnx.ExecuteAsync("Update_depots", param, commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result > 0;
            }
            throw new NotImplementedException();
        }
    }
}
