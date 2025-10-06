using Microsoft.AspNetCore.Mvc;

namespace Portal_de_Eventos.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
