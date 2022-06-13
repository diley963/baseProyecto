using ProjectBase.Negocio.Clientes;
using ProjectBase.Negocio.Contratos.Persistencia;

namespace ProjectBase.Negocio.Fachadas
{
    public class Fachada : IFachada
    {
        ConsultasCliente consultaCliente = new ConsultasCliente();
        ComandosCliente operacionesCliente = new ComandosCliente();
        private static Fachada? fachada;
        public static Fachada Instance
        {
            get
            {
                if (fachada == null)
                {
                    fachada = new Fachada();
                }

                return fachada;
            }
        }

        public ClienteRequest GetCustomer(int id)
        {
            return consultaCliente.GetCustomer(id);
        }

        public bool create(ClienteRequest peticion)
        {
            return operacionesCliente.create(peticion);
        }
    }
}
