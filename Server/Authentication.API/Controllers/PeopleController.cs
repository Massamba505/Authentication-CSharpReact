using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok("People Data");
        }

        [HttpPost]
        public IActionResult PostPerson()
        {
            return Ok("Person is created");
        }

        [HttpPut]
        public IActionResult putPerson()
        {
            return Ok("Person updated");
        }

        [HttpDelete]
        public IActionResult DeletePerson()
        {
            return Ok();
        }
    }
}
