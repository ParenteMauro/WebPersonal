using Microsoft.AspNetCore.Mvc;

namespace WebPersonal.BackEnd.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilPersonalController : Controller
    {
        [HttpGet("Profile/{id}")]
        public string Get(int id)
        {
            return id switch
            {
                1 => "Mauro",
                2 => "TestS",
                _ => throw new NotImplementedException("id no valido")
            };
        }
        [HttpPost]
        public string Post(PerfilPersonalDto perfilPersonal)
        {
            return perfilPersonal.Nombre;
        }
    }

    public class PerfilPersonalDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }

}
