using Microsoft.AspNetCore.Mvc;
using ProjectBase.Negocio.Clientes;
using ProjectBase.Negocio.Contratos.Persistencia;
using ProjectBase.Negocio.Fachadas;

namespace DelegadaServicios.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PeticionController : ControllerBase
    {
        private readonly IFachada _fachada;

        public PeticionController(IFachada fachada)
        {
            _fachada = fachada;
        }

        [HttpGet]
        public string Create(ClienteRequest peticion)
        {
            var resultado = new DelegadaProjecBase(_fachada);
        }
            return "ff";
            
    }
}
