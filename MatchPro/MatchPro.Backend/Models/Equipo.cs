using System.ComponentModel.DataAnnotations;

namespace MatchPro.Backend.Models
{
    public class Equipo
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; } = null!;

        public string? Logo { get; set; }
    }
}
