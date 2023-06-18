using Interface.Characters;
using Response.Characters;
using DA = Database.Characters;

namespace Bussiness.Characters
{
    public class BOCharacter : ICharacter<ResCharacter>
    {
        private readonly DA.DBCharacter daCharacter;
        private readonly DA.DBTransformation daTransformation;

        public BOCharacter()
        {
            daCharacter = new DA.DBCharacter();
            daTransformation = new DA.DBTransformation();
        }


        public async Task<ResCharacter> GetCharacter(string name)
        {
            try {
                ResCharacter character = await daCharacter.GetCharacter(name);
                character.Transformation = await daTransformation.ListTransformations(character.idCharacter);

                return character;
            }
            catch {

                throw;
            }
        }

    }
}
