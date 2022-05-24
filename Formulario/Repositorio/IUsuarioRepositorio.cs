using Formulario.Models;

namespace Formulario.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<Usuarios> ListaUsuarios();
        Usuarios ListarPorId(int id);
        Usuarios Adicionar(Usuarios usuario);
        Usuarios Atualizar(Usuarios usuario);
        bool Apagar(int id);
    }
}
