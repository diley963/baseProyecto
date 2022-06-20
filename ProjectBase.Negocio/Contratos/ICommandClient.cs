using ProjectBase.Negocio.Clientes;

namespace ProjectBase.Negocio.Contratos
{
    public interface ICommandClient
    {
        bool create(ClienteRequest peticion);
    }
}
