using MisPrimerasAPIS.Modelos;

namespace MisPrimerasAPIS.Repository
{
    public class EstudianteRepository
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
