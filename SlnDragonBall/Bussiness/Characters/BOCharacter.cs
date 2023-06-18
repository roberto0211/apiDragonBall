using Interface.Characters;
using Response.Characters;
using DA = Database.Characters;

namespace Bussiness.Characters
{
    public class BOCharacter : ICharacter<RESCharacter>
    {
        private readonly DA.DBCharacter daCharacter;

        public BOCharacter()
        {
            daCharacter = new DA.DBCharacter();
        }


        public async Task<RESCharacter> ListCharacter(string name)
        {
            try {
                return await daCharacter.ListCharacter(name);
            }
            catch {

                throw;
            }
        }
    }
}
