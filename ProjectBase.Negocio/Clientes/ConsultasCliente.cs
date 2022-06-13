using ProjectBase.Negocio.Contratos;
using ProjectBase.Negocio.Contratos.Persistencia;
using ProjectBase.Negocio.Repositorios;

namespace ProjectBase.Negocio.Clientes
{
    public class ConsultasCliente : IReadClient
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConsultasCliente()
        {
            _unitOfWork = new UnitOfWorkSqlServer();
        }
        public ClienteRequest GetCustomer(int id) 
        {
            using (var context = _unitOfWork.Create())
            {
                
                var record = context.Repositories.ClientRepository.Get(id);
                if (record != null)
                {
                    //mapping recor en clienterequest
                }
                return new ClienteRequest();
            };
        }
    }
}
