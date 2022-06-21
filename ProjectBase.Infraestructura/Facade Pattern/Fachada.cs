using ProjectBase.Infraestructura.Contratos;
using ProjectBase.Negocio.Clientes;
using ProjectBase.Negocio.Contratos.Persistencia;

namespace ProjectBase.Infraestructura.Facade_Pattern
{
    public class Fachada : IFachada
    {        
        private readonly IClientRepository _clientRepository;
        //private readonly ComandosCliente _operacionesCliente;

        public Fachada(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public bool create(ClienteRequest peticion)
        {
            _clientRepository.CrearCLiente(peticion);
           
            return true;
        }
    }

}
