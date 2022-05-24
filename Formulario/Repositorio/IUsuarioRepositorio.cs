using Formulario.Models;

namespace Formulario.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<Usuarios> ListaUsuarios();
        Usuarios Adicionar(Usuarios usuario);
    }
}
