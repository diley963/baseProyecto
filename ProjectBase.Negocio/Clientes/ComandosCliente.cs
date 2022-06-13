using ProjectBase.Negocio.Contratos;
using ProjectBase.Negocio.Contratos.Persistencia;
using ProjectBase.Negocio.Repositorios;

namespace ProjectBase.Negocio.Clientes
{
    public class ComandosCliente : ICommandClient
    {
        private readonly IUnitOfWork _unitOfWork;

        public ComandosCliente()
        {
            _unitOfWork = new UnitOfWorkSqlServer();
        }
        public bool create(ClienteRequest peticion)
        {
            using (var context = _unitOfWork.Create())
            {
                var confirmacion = context.Repositories.ClientRepository.Create(peticion);
               
                return confirmacion;
            };
        }
    }
}
