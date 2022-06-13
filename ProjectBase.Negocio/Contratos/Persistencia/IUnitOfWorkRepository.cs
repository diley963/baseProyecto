using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBase.Negocio.Contratos.Persistencia
{
    public interface IUnitOfWorkRepository
    {
        IClientRepository ClientRepository { get; }
    }
}
