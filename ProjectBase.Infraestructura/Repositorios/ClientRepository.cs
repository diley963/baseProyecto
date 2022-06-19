using Npgsql;
using NpgsqlTypes;
using ProjectBase.Negocio.Clientes;
using System.Data;
using System.Data.SqlClient;

namespace ProjectBase.Infraestructura.Repositorios
{
    public class ClientRepository : Repository
    {
        private NpgsqlCommand _comandoGeneral;
        public ClientRepository()
        {
            _comandoGeneral = new NpgsqlCommand();

        }

        public void CrearCLiente(ClienteRequest cliente)
        {
            _comandoGeneral.Parameters.Clear();


            _comandoGeneral.Parameters.Add("@id", NpgsqlDbType.Integer);
            _comandoGeneral.Parameters["@id"].Value = cliente.Id;

            //comandoGeneral.Parameters.Add("@barcod", SqlDbType.NVarChar);
            //comandoGeneral.Parameters["@barcod"].Value = productos.BarcodProducto;

            //comandoGeneral.Parameters.Add("@descripcion", SqlDbType.NVarChar);
            //comandoGeneral.Parameters["@descripcion"].Value = productos.DescripcionProducto;


            //comandoGeneral.Parameters.Add("@estado", SqlDbType.Bit);
            //comandoGeneral.Parameters["@estado"].Value = productos.EstadoProducto;

            //comandoGeneral.Parameters.Add("@CodigoCategoria", SqlDbType.BigInt);
            //comandoGeneral.Parameters["@CodigoCategoria"].Value = productos.CodigoCategoriaProductoGeneral;
            EjecutarInstruccion(_comandoGeneral, "spCrearCliente");
        }
    }
}
