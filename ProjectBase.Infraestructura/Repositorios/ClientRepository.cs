using Npgsql;
using NpgsqlTypes;
using ProjectBase.Negocio.Clientes;
using ProjectBase.Negocio.Contratos.Persistencia;

namespace ProjectBase.Infraestructura.Repositorios
{
    public class ClientRepository : Repository, IClientRepository
    {
        private NpgsqlCommand _comandoGeneral;
        public ClientRepository()
        {
            _comandoGeneral = new NpgsqlCommand();
        }

        public bool CrearCLiente(ClienteRequest cliente)
        {
            //en caso de necesitar logica
            var logicaNegocio = new ComandosCliente().Create(cliente);
            if (logicaNegocio)
            {
                //guarda datos en bd
                _comandoGeneral.Parameters.Clear();
                _comandoGeneral.Parameters.Add("@id", NpgsqlDbType.Integer);
                _comandoGeneral.Parameters["@id"].Value = cliente.Id;
                EjecutarInstruccion(_comandoGeneral, "spCrearCliente");
                return true;
            }
            return false;
        }
    }
}
