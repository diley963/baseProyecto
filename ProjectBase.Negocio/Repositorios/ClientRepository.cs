using ProjectBase.Dominio;
using ProjectBase.Negocio.Clientes;
using ProjectBase.Negocio.Contratos.Persistencia;
using System.Data.SqlClient;

namespace ProjectBase.Negocio.Repositorios
{
    public class ClientRepository : Repository, IClientRepository
    {
        public ClientRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public Cliente Get(int id)
        {
            var command = CreateCommand("SELECT * FROM clients WITH(NOLOCK) WHERE id = @clientId");
            command.Parameters.AddWithValue("@clientId", id);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                return new Cliente
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString()
                };
            }
        }

        public bool Create(ClienteRequest peticion)
        {
            return true;
        }
    }
}
