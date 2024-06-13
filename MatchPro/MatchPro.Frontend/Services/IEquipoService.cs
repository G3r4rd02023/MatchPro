using MatchPro.Shared;

namespace MatchPro.Frontend.Services
{
    public interface IEquipoService
    {
        Task<List<EquipoDTO>> Lista();
        Task<EquipoDTO> Buscar(int id);
        Task<int> Guardar( EquipoDTO equipo);
        Task<int> Editar(int id, EquipoDTO equipo);
        Task<bool> Eliminar(int id);
    }
}
