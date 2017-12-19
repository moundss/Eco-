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
using System.Linq;


namespace Ecoplus.Infrastructure.Repository
{
    
    public class DepotRepositories : IDepotRepositories
    {
        private readonly string _strcnx = ConfigurationManager.ConnectionStrings["Database:Ecoplus"].ConnectionString;
     

        public async Task<bool> Enregistrer(Depot mondepot)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                cnx.Open();
                var param=new DynamicParameters();
               // param.Add("@id",mondepot.Id);
                param.Add("@libelle",mondepot.Libelle);
                param.Add("@Qte_stocke",mondepot.Qte);
                param.Add("@Qte_limite",mondepot.Qtelimit);
                param.Add("@localisation",mondepot.Localisation);
                param.Add("@semence", mondepot.Semence);
                var result = await cnx.ExecuteAsync("Insert_depots",param,commandType:CommandType.StoredProcedure);
                //var result = await cnx.ExecuteAsync("Insert_depots",param,commandType:CommandType.StoredProcedure);

                return result>0;
            }
            throw new System.NotImplementedException();
        }

        public async Task<bool> Supprimer(int idDepot)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                var param = new DynamicParameters();
                param.Add("@idDepots",idDepot);
                cnx.Open();
                var result =await cnx.ExecuteAsync("Delete_depots", param, commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result > 0;
            }
            throw new System.NotImplementedException();
        }

        public async Task<bool> Modifier(int idDepot,Depot monDepot)
        {
            using (var cnx=new SqlConnection(_strcnx))
            {
                var param=new DynamicParameters();
                param.Add("@id", idDepot);
                param.Add("@libelle", monDepot.Libelle);
                param.Add("@Qte_stocke", monDepot.Qte);
                param.Add("@Qte_limite", monDepot.Qtelimit);
                param.Add("@localisation", monDepot.Localisation);
                param.Add("@semence",monDepot.Semence);
                cnx.Open();
                var result = await cnx.ExecuteAsync("Update_depots", param, commandType: CommandType.StoredProcedure);
                cnx.Close();
                return result > 0;
            }
            throw new NotImplementedException();
        }

        List<DepotDtos> IDepotRepositories.Listedepot()
        {
            using (var cnx = new SqlConnection(_strcnx))
            {

                cnx.Open();
                var result = (List<DepotDtos>)cnx.Query<DepotDtos>("Select_depots", commandType: CommandType.StoredProcedure);

                return result;
            }
            throw new NotImplementedException();
        }
    }
}
