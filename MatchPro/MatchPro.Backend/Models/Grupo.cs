using System.ComponentModel.DataAnnotations;

namespace MatchPro.Backend.Models
{
    public class Grupo
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; } = null!;

        public Torneo Torneo { get; set; } = null!;

        public int TorneoId { get; set; }

    }
}
