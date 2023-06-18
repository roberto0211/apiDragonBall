using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using BO = Bussiness.Characters;

namespace ApiDragonBall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : Controller
    {
        private readonly BO.BOCharacter boCharacter;
        public CharacterController()
        {
            boCharacter = new();
        }


        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("Character")]
        [HttpGet]
        public async Task<IActionResult> Character([Required]string name)
        {
            try
            {
                var result = await boCharacter.ListCharacter(name);
                return Ok(result);
            }
            catch (SqlException sqlex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
