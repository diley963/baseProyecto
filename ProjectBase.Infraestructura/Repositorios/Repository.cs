using Npgsql;
using NpgsqlTypes;
using ProjectBase.Negocio.Clientes;
using System.Data;
using System.Data.SqlClient;

namespace ProjectBase.Infraestructura.Repositorios
{
    public class Repository
    {
        private StrCadenaConexion conf = new StrCadenaConexion();
        private NpgsqlConnection Conn = new NpgsqlConnection();
        private NpgsqlTransaction transaccion = null;

        private NpgsqlConnection Conexion()
        {
            try
            {
                Conn = new NpgsqlConnection(conf.Cadena);
                Conn.Open();

                //transaccion = Conn.BeginTransaction();
                return Conn;
            }
            catch (Exception)
            {

                throw;
            }
            // DefaultSettingValueAttribute () ;//= new DefaultSettingValueAttribute();

        }

        public void EndConec()
        {
            //transaccion.Dispose();
            Conn.Close();

        }

        public DataTable EjecutarInstrucciones(string strSentenciaSQL)
        {
            DataTable CargarTablaInstruccion = new DataTable();
            NpgsqlCommand ComandoEjecutarInstrucciones = new NpgsqlCommand(strSentenciaSQL, Conexion());
            NpgsqlDataAdapter AdaptadorEjecutarInstrucciones = new NpgsqlDataAdapter(ComandoEjecutarInstrucciones);
            AdaptadorEjecutarInstrucciones.Fill(CargarTablaInstruccion);
            EndConec();
            return CargarTablaInstruccion;

        }

        public DataTable EjecutarProcedimiento(NpgsqlCommand Commando, string NombreProcedimiento)
        {
            DataTable CargarTablaProcedimiento = new DataTable();

            Commando.CommandText = NombreProcedimiento.ToString();//NombreProcedimiento.ToString();
            Commando.Connection = Conexion();
            Commando.Transaction = transaccion;
            Commando.CommandType = CommandType.StoredProcedure;
            NpgsqlDataAdapter AdaptadorEjecutarProcedimiento = new NpgsqlDataAdapter(Commando);
            AdaptadorEjecutarProcedimiento.Fill(CargarTablaProcedimiento);
            EndConec();
            return CargarTablaProcedimiento;

        }


        public void EjecutarInstruccion(NpgsqlCommand Commando, string NombreProcedimiento)
        {

            Commando.Connection = Conexion();
            Commando.CommandText = NombreProcedimiento.ToString();//NombreProcedimiento.ToString();
            Commando.Transaction = transaccion;
            Commando.CommandType = CommandType.StoredProcedure;

            try
            {
                Commando.ExecuteNonQuery();
                //transaccion.Commit();
                EndConec();
            }
            catch (NpgsqlException Ex)
            {
                transaccion.Rollback();
                var err = Ex.ErrorCode;
                string mensaje = string.Empty;
                switch (err)
                {
                    case 109:
                        mensaje = "Problemas con insert"; break;
                    case 110:
                        mensaje = "Más problemas con insert"; break;
                    case 113:
                        mensaje = "Problemas con comentarios"; break;
                    case 156:
                        mensaje = "Error de sintaxis"; break;
                    case 547:
                        mensaje = "El registro tiene relacionada información, elimine los registros asociados para así continuar con el proceso."; break;
                }
                EndConec();

                throw new ArgumentException(mensaje);
            }


        }


    }
}
