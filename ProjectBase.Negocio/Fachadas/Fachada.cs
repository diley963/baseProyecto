using ProjectBase.Negocio.Clientes;
using ProjectBase.Negocio.Contratos.Persistencia;

namespace ProjectBase.Negocio.Fachadas
{
    public class Fachada : IFachada
    {
        private readonly IClientRepository _clientRepository;
        private readonly ComandosCliente _operacionesCliente;

        public Fachada(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            _operacionesCliente = new ComandosCliente(_clientRepository);

        }

        ConsultasCliente consultaCliente = new ConsultasCliente();
        private static Fachada? fachada;
        public Fachada Instance
        {
            get
            {
                if (fachada == null)
                {
                    fachada = new Fachada(_clientRepository);
                }

                return fachada;
            }
        }

        //public ClienteRequest GetCustomer(int id)
        //{
        //    return consultaCliente.GetCustomer(id);
        //}

        public void create(ClienteRequest peticion)
        {
             _operacionesCliente.create(peticion);
        }
    }
}
