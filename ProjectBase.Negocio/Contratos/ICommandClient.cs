using ProjectBase.Negocio.Clientes;

namespace ProjectBase.Negocio.Contratos
{
    public interface ICommandClient
    {
        void create(ClienteRequest peticion);
    }
}
