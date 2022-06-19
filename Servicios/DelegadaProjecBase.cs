using ProjectBase.Negocio.Contratos.Persistencia;
using ProjectBase.Negocio.Fachadas;

namespace DelegadaServicios
{
    public class DelegadaProjecBase
    {
        private readonly Fachada _fachada;
        private readonly IFachada? _servicioClientes;
        public DelegadaProjecBase(Fachada fachada)
        {
            _fachada = fachada;
            _servicioClientes = _fachada.Instance;
            ServiciosClientes = _servicioClientes;
        }

        public static IFachada? ServiciosClientes
        {
            get; private set;
        }
    }
}
