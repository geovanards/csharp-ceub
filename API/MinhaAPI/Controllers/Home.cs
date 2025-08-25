using Microsoft.AspNetCore.Mvc; // Define o namespace (área de organização) do projeto.

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route ("")]
    public class HomeController : ControllerBase{
        [HttpGet]
        public IActionResult Index(){
            return Ok(new {message = "Oi novamente!"});
        }
    }
}