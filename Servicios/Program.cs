using ProjectBase.Infraestructura.Contratos;
using ProjectBase.Infraestructura.Facade_Pattern;
using ProjectBase.Infraestructura.Repositorios;
using ProjectBase.Negocio.Contratos.Persistencia;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseS(connectionString));

builder.Services.AddScoped<IFachada, Fachada>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
