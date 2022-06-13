using ProjectBase.Negocio.Contratos.Persistencia;
using ProjectBase.Negocio.Fachadas;

namespace ProjectBase.Presentacion.Delegada
{
    public class DelegadaProjectBase
    {
        private DelegadaProjectBase() { }

        private static IFachada servicioClientes = (IFachada)Fachada.Instance;
        public static IFachada servicioClientes
        {
            get { return servicioClientes; }
        }


    }
}
