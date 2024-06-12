namespace MatchPro.Backend.Models
{
    public class DetalleGrupo
    {
        public int Id { get; set; }

        public int EquipoId { get; set; }

        public Equipo Equipo { get; set; } = null!;

        public int PartidosJugados {  get; set; }

        public int PartidosGanados { get; set; }

        public int PartidosEmpatados { get; set; }

        public int PartidosPerdidos { get; set; }

        public int GolesAnotados { get; set; }

        public int GolesRecibidos { get; set; }

        public int GrupoId { get; set; }

        public Grupo Grupo { get; set; } = null!;


    }
}
