using System.ComponentModel.DataAnnotations;

namespace MatchPro.Backend.Models
{
    public class Torneo
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime FechaInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime FechaFinal { get; set; }

        public bool Activo { get; set; }

        public string? Logo { get; set; }

    }
}
