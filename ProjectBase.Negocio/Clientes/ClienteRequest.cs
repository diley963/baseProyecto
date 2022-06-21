namespace ProjectBase.Negocio.Clientes
{
    public class ClienteRequest
    {
        public int Id { get; set; } = 1;
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public int? Telefono { get; set; }
    }
}
