using Dapper;
using Interface.Characters;
using Microsoft.Data.SqlClient;
using Response.Characters;
using System.Data;

namespace Database.Characters
{
    public class DBTransformation: ITransformation<ResTransformation>
    {
        public SqlConnection? Con { get; set; }
        public DBTransformation()
        {

        }
        public async Task<List<ResTransformation>> ListTransformations(int idCharacter)
        {
            List<ResTransformation> listTransformations;
            using (Con = ConnectionFactory.GetConnection())
            {
                var param = new DynamicParameters();
                param.Add("@idCharacter", idCharacter);

                var result = await Con.QueryMultipleAsync("sp_getTransformations", param, commandType: CommandType.StoredProcedure);

                listTransformations = result.Read<ResTransformation>().ToList();

                return listTransformations;
            }
        }
    }
}
