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

        public async Task<EquipoDTO> Buscar(int id)
        {
            var response = await _http.GetFromJsonAsync<EquipoDTO>($"api/Equipos/{id}");
            if (response != null)
            {
                return response;
            }
            throw new Exception($"No se encontró el equipo con ID {id}");
        }

        public async Task<int> Editar(int id, EquipoDTO equipo)
        {
            var response = await _http.PutAsJsonAsync($"api/Equipos/{id}", equipo);
            if (response.IsSuccessStatusCode) 
            {
                return 1;
            }
            return 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"api/Equipos/{id}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            throw new Exception($"No se encontró el equipo con ID {id}");
        }

        public async Task<int> Guardar(EquipoDTO equipo)
        {
            var response = await _http.PostAsJsonAsync("api/Equipos", equipo);
            if (response.IsSuccessStatusCode)
            {                                
                return 1;
            }
            return 0;
        }

        public async Task<List<EquipoDTO>> Lista()
        {
            return await _http.GetFromJsonAsync<List<EquipoDTO>>("api/Equipos") ?? new List<EquipoDTO>();
        }
    }
}
