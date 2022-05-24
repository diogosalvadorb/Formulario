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

        public IActionResult Editar(int id)
        {
            Usuarios usuario =  _usuariosRepositorio.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult ConfirmarDelete(int id)
        {
            Usuarios usuario = _usuariosRepositorio.ListarPorId(id);

            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            _usuariosRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(Usuarios usuario)
        {
            _usuariosRepositorio.Adicionar(usuario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(Usuarios usuario)
        {
            _usuariosRepositorio.Atualizar(usuario);
            return RedirectToAction("Index");
        }
    }
}
