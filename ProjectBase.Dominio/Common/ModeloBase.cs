namespace ProjectBase.Dominio.Common
{
    public abstract class ModeloBase
    {
        public int Id { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }
        public string? modificadoPor { get; set; }
    }
}
