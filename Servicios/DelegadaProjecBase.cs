using ProjectBase.Infraestructura.Contratos;
using ProjectBase.Infraestructura.Facade_Pattern;
using ProjectBase.Negocio.Clientes;

namespace DelegadaServicios
{
    public class DelegadaProjecBase
    {
        private readonly IFachada _fachada;
        
        public DelegadaProjecBase(IFachada fachada)
        {
            _fachada = fachada;
        }

        
    }
}
