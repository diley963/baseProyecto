using ProjectBase.Negocio.Contratos.Persistencia;
using System.Data.SqlClient;

namespace ProjectBase.Negocio.Repositorios
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {
        public IClientRepository ClientRepository { get; }

        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            ClientRepository = new ClientRepository(context, transaction);
        }
    }
}
