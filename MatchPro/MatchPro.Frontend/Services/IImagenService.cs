namespace MatchPro.Frontend.Services
{
    public interface IImagenService
    {
        Task<string> SubirImagen(Stream archivo, string nombre);
    }
}
