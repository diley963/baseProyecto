using ProjectBase.Dominio;
using ProjectBase.Negocio.Contratos.Persistencia.Acciones;

namespace ProjectBase.Negocio.Contratos.Persistencia
{
    public interface IClientRepository : IReadRepository<Cliente, int>
    {

    }
}
