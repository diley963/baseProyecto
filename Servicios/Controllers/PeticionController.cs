using Microsoft.AspNetCore.Mvc;
using ProjectBase.Infraestructura.Contratos;
using ProjectBase.Negocio.Clientes;
using System.Text.Json;

namespace DelegadaServicios.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PeticionController : ControllerBase
    {
        private readonly IFachada _fachada;
        delegate bool delegadaClientes(ClienteRequest cliente);

        public PeticionController(IFachada fachada)
        {
            _fachada = fachada;
        }

        [HttpPost]
        public bool Procedimientos(string peticion)
        {

            ClienteRequest peticionx = new ClienteRequest();
            peticionx = JsonSerializer.Deserialize<ClienteRequest>(peticion);


            delegadaClientes delegada = delegate (ClienteRequest cliente)
            {
                return _fachada.create(cliente);
            };

            return delegada(peticionx);             
        }
            
            
    }
}
