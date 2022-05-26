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
            try
            {
                bool apagado =  _usuariosRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Formulário apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemError"] = "Não foi possível apagar o formulário";
                }

                return RedirectToAction("Index");
            }
            catch (Exception error)
            {
                TempData["MensagemError"] = $"Não foi possível apagar o formulário, erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(Usuarios usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuariosRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Formulário cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch (Exception error)
            {
                TempData["MensagemError"] = $"Não foi possível cadastrar o formulário, Erro:{error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(Usuarios usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuariosRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Informação alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", usuario);
            }
            catch (Exception error)
            {
                TempData["MensagemError"] = $"Não foi possível atualizar o formulário, Erro:{error.Message}";
                return RedirectToAction("Index");
            }          
        }
    }
}
