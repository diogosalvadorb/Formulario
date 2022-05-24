using Formulario.Models;
using Formulario.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Formulario.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _usuariosRepositorio;
        public UsuariosController(IUsuarioRepositorio usuariosRepositorio)
        {
            _usuariosRepositorio = usuariosRepositorio;
        }

        public IActionResult Index()
        {
            var usuarios = _usuariosRepositorio.ListaUsuarios();
            return View(usuarios);
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

        [HttpPost]
        public IActionResult Criar(Usuarios usuario)
        {
            _usuariosRepositorio.Adicionar(usuario);
            return RedirectToAction("Index");
        }
    }
}
