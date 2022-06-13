using ProjectBase.Negocio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBase.Negocio.Contratos.Persistencia.Acciones
{
    public interface IReadRepository<T, Y> where T : class
    {
        bool Create(ClienteRequest peticion);
        T Get(Y id);
    }
}
