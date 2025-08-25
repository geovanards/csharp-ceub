using Microsoft.AspNetCore.Mvc; // Define o namespace (área de organização) do projeto.

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route ("hello")]
    public class HelloController : ControllerBase{
        [HttpGet]
        public IActionResult Get(){
            return Ok(new {message = "Hello World!"});
        }
    }
}