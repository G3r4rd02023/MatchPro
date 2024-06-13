using MatchPro.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace MatchPro.Frontend.Services
{
    public class EquipoService : IEquipoService
    {
        private readonly HttpClient _http;

        public EquipoService(HttpClient http)
        {
            _http = http;
        }

        public Task<EquipoDTO> Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Editar(EquipoDTO empleado)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Guardar(EquipoDTO empleado)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EquipoDTO>> Lista()
        {
            return await _http.GetFromJsonAsync<List<EquipoDTO>>("api/Equipos") ?? new List<EquipoDTO>();
        }
    }
}
