using ProjectBase.Negocio.Clientes;

namespace ProjectBase.Negocio.Contratos.Persistencia
{
    public interface IClientRepository
    {
        public void CrearCLiente(ClienteRequest cliente);
    }
}
