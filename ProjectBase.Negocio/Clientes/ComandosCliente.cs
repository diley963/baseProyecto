using ProjectBase.Dominio;
using ProjectBase.Negocio.Contratos;
using ProjectBase.Negocio.Contratos.Persistencia;

namespace ProjectBase.Negocio.Clientes
{
    public class ComandosCliente
    {
        private readonly IClientRepository _clientRepository;

        public ComandosCliente(IClientRepository clientRepository)
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
