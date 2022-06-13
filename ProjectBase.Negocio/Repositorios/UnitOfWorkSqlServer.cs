using Microsoft.Extensions.Configuration;
using ProjectBase.Negocio.Contratos.Persistencia;

namespace ProjectBase.Negocio.Repositorios
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        private readonly IConfiguration _configuration;

        public UnitOfWorkSqlServer(IConfiguration configuration = null)
        {
            _configuration = configuration;
        }



        public IUnitOfWorkAdapter Create()
        {
            var connectionString = "SqlConnectionString";

            return new UnitOfWorkSqlServerAdapter(connectionString);
        }
    }
}
