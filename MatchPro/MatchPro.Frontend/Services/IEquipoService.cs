using MatchPro.Shared;

namespace MatchPro.Frontend.Services
{
    public interface IEquipoService
    {
        Task<List<EquipoDTO>> Lista();
        Task<EquipoDTO> Buscar(int id);
        Task<int> Guardar(EquipoDTO empleado);
        Task<int> Editar(EquipoDTO empleado);
        Task<bool> Eliminar(int id);
    }
}
