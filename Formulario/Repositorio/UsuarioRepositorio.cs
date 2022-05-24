using Formulario.Data;
using Formulario.Models;

namespace Formulario.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly FormularioContext _formularioContext;
        public UsuarioRepositorio(FormularioContext formularioContext)
        {
            _formularioContext = formularioContext;
        }

        public List<Usuarios> ListaUsuarios()
        {
            return _formularioContext.Usuarios.ToList();
        }

        public Usuarios Adicionar(Usuarios usuario)
        {
            //salva no banco de dados
            _formularioContext.Usuarios.Add(usuario);
            _formularioContext.SaveChanges();

            return usuario;
        }
    }
}
