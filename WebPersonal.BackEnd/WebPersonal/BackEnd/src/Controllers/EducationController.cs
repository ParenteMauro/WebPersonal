using Microsoft.AspNetCore.Mvc;
using WebPersonal.BackEnd.src.Model.Entity;
using WebPersonal.Shared.SharedDTO;

namespace WebPersonal.BackEnd.src.Controllers
{
    [ApiController]
    [Route("api/controller")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class EducationController
    {
        [HttpGet]
        public Task<EducationDto?> Get()
        {
            var entity = EducationEntity.Create()
        }
    }
}
