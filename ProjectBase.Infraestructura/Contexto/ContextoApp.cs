using Microsoft.EntityFrameworkCore;
using ProjectBase.Dominio;

namespace ProjectBase.Infraestructura.Contexto
{
    public class ContextoApp : DbContext
    {
        public ContextoApp(DbContextOptions<ContextoApp> options) : base(options)
        {
        }

        public virtual DbSet<Cliente>? Clientes { get; set; }
        


        //Fluent API
        
    }

}
