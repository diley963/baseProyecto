using ProjectBase.Dominio.Common;

namespace ProjectBase.Dominio
{
    public class Cliente : ModeloBase 
    {
        public Cliente()
        {
            Direcciones = new HashSet<string>();
        }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public IEnumerable<string> Direcciones { get; set; }

    }
}
