using Dapper;
using Interface.Characters;
using Microsoft.Data.SqlClient;
using Response.Characters;
using System.Data;

namespace Database.Characters
{
    public class DBCharacter: ICharacter<ResCharacter>
    {
        public SqlConnection? Con { get; set; }
        public DBCharacter()
        {

        }
        public async Task<ResCharacter> GetCharacter(string name)
        {
            using (Con = ConnectionFactory.GetConnection())
            {
                var param = new DynamicParameters();
                param.Add("@name", name);
 
                var result = await Con.QueryFirstOrDefaultAsync<ResCharacter>("sp_getCharacter", param, commandType: CommandType.StoredProcedure);          
                return result;
            }
        }
    }
}