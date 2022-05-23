using Microsoft.AspNetCore.Mvc;

namespace Formulario.Controllers
{
    public class Usuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ConfirmarDelete()
        {
            return View();
        }
    }
}
