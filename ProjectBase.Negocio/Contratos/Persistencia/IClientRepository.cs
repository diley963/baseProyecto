using ProjectBase.Negocio.Clientes;

namespace ProjectBase.Negocio.Contratos.Persistencia
{
    public interface IClientRepository
    {
        public bool CrearCLiente(ClienteRequest cliente);
    }
}
