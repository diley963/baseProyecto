using Microsoft.AspNetCore.Mvc;
using ProjectBase.Negocio.Clientes;
using ProjectBase.Negocio.Fachadas;

namespace ProjectBase.Presentacion.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            var idCliente = 4;
            var peticion = new ClienteRequest();
            var fachada = new Fachada();
            fachada.GetCustomer(idCliente);
            fachada.create(peticion);
            return View();
        }
    }
}
