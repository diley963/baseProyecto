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
                _comandoGeneral.Parameters.AddWithValue(":_nombre", NpgsqlDbType.Varchar).Value = cliente.Nombre;
                _comandoGeneral.Parameters.AddWithValue(":_identificacion", NpgsqlDbType.Integer).Value = cliente.Telefono;
                EjecutarInstruccion(_comandoGeneral, "public.prueba_crear");
                return true;
            }
            return false;
        }
    }
}
