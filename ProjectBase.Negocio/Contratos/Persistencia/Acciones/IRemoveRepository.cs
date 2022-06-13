using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBase.Negocio.Contratos.Persistencia.Acciones
{
    public interface IRemoveRepository<T>
    {
        void Remove(T id);
    }
}
