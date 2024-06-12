namespace MatchPro.Backend.Models
{
    public class Prediccion
    {
        public int Id { get; set; }

        public int PartidoId { get; set; }

        public Partido Partido { get; set; } = null!;

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; } = null!;

        public int GolesLocal { get; set; }

        public int GolesVisitante { get; set; }

        public int Puntos { get; set; }
    }
}
