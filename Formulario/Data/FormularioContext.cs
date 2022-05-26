using Microsoft.EntityFrameworkCore;
using Formulario.Models;

namespace Formulario.Data
{
    public class FormularioContext : DbContext
    {
        public FormularioContext (DbContextOptions<FormularioContext> options)
            : base(options)
        {
        }

        public DbSet<Usuarios>? Usuarios { get; set; }
    }
}
