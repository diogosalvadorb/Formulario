using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<Formulario.Models.Usuarios>? Usuarios { get; set; }
    }
}
