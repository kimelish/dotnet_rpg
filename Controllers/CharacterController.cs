using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Models {
    [ApiController]
    [Route ("[controller]")]
    public class CharacterController : ControllerBase {
        private static Character knight = new Character ();
        private static List<Character> characters = new List<Character> {
            new Character (),
            new Character { Id = 1, Name = "Sam" }
        };

        [HttpGet ("GetAll")]
        public IActionResult Get () {
            return Ok (characters);
        }

        [Route ("{id}")]
        public IActionResult GetSingle (int id) {
            return Ok (characters.FirstOrDefault (c => c.Id == id));
        }

        [HttpPost]
        public IActionResult AddCharacter (Character newCharacter) {
            characters.Add (newCharacter);
            return Ok (characters);

        }

    }
}