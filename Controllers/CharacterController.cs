using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Models 
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        public IActionResult Get ()
        {
            return Ok(knight);
        }

    }
}