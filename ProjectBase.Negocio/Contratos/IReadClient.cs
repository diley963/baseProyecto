using ProjectBase.Negocio.Clientes;

namespace ProjectBase.Negocio.Contratos
{
    public interface IReadClient
    {
        ClienteRequest GetCustomer(int id);
    }
}
