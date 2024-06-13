using System.ComponentModel.DataAnnotations;

namespace MatchPro.Shared
{
    public class PartidoDTO
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime Fecha { get; set; }

        public EquipoDTO Local { get; set; } = null!;

        public int EquipoLocalId { get; set; }

        public EquipoDTO Visitante { get; set; } = null!;

        public int EquipoVisitanteId { get; set; }

        public bool Cerrado { get; set; }

        public GrupoDTO Grupo { get; set; } = null!;

        public int GrupoId { get; set; }
    }
}
