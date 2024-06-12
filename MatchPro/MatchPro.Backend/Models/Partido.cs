using System.ComponentModel.DataAnnotations;

namespace MatchPro.Backend.Models
{
    public class Partido
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime Fecha { get; set; }

        public Equipo Local { get; set; } = null!;

        public int EquipoLocalId { get; set; }

        public Equipo Visitante { get; set; } = null!;

        public int EquipoVisitanteId { get; set; }

        public bool Cerrado { get; set; }

        public Grupo Grupo { get; set; } = null!;

        public int GrupoId { get; set; }
    }
}
