using Microsoft.AspNetCore.Mvc;

namespace WebPersonal.BackEnd.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilPersonalController : Controller
    {
        [HttpGet("LeerPerfil/{id}")]
        public string Get(int id)
        {
            return id switch
            {
                1 => "Ivan",
                2 => "Curso",
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
