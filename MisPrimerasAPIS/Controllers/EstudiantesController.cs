using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MisPrimerasAPIS.Modelos;

namespace MisPrimerasAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        [Route("InformacionEstudiantes")]
        [HttpGet]
        public Estudiante DevueveInformacionEstudiantes()
        {
            Estudiante estudiante = new Estudiante
            {
                Id = 1,
                Nombre = "Satiago",
                Edad = 30,
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true,
            };
            return estudiante;
        }
    }
}
