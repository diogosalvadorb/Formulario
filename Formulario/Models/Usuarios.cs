using System.ComponentModel.DataAnnotations;

namespace Formulario.Models
{
    public class Usuarios
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [MaxLength(70)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cidade { get; set; } = string.Empty;

        [MaxLength(150)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string EMail { get; set; } = string.Empty;

        [MaxLength(18)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Telefone { get; set; } = string.Empty;
    }
}
