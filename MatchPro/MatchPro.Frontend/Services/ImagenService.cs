
using Firebase.Auth;
using Firebase.Storage;

namespace MatchPro.Frontend.Services
{
    public class ImagenService : IImagenService
    {
        public async Task<string> SubirImagen(Stream archivo, string nombre)
        {           

            string email = "tu_email";
            string clave = "tu_clave";
            string ruta = "tu_ruta";
            string api_key = "tu_api_key";


            var auth = new FirebaseAuthProvider(new FirebaseConfig(api_key));
            var a = await auth.SignInWithEmailAndPasswordAsync(email, clave);

            var cancellation = new CancellationTokenSource();

            var task = new FirebaseStorage(
              ruta,
              new FirebaseStorageOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                  ThrowOnCancel = true
              })

               .Child("Fotos_Perfil")
               .Child(nombre)
               .PutAsync(archivo, cancellation.Token);

            var downloadURL = await task;
            return downloadURL!;
        }
    }
}
