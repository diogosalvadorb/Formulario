using Formulario.Data;
using Formulario.Models;

namespace Formulario.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly FormularioContext _context;
        public UsuarioRepositorio(FormularioContext formularioContext)
        {
            _context = formularioContext;
        }

        public List<Usuarios> ListaUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuarios ? ListarPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public Usuarios Adicionar(Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return usuario;
        }

        public Usuarios Atualizar(Usuarios usuario)
        {
            Usuarios usuarioDb = ListarPorId(usuario.Id);

            if (usuarioDb == null) throw new Exception("Houve um erro na atualização do usuario!");

            usuarioDb.Nome = usuario.Nome;
            usuarioDb.Cidade = usuario.Cidade;
            usuarioDb.EMail = usuario.EMail;
            usuarioDb.Telefone = usuario.Telefone;

            _context.Usuarios.Update(usuarioDb);
            _context.SaveChanges();

            return usuarioDb;
        }

        public bool Apagar(int id)
        {
            Usuarios usuarioDb = ListarPorId(id);

            if (usuarioDb == null) throw new Exception("Houve um erro ao deleter usuario");

            _context.Usuarios.Remove(usuarioDb);
            _context.SaveChanges();

            return true;
        }
    }
}
