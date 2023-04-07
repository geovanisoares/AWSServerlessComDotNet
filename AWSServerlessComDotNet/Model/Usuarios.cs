using System.Text.Json;
using System.Text.Json.Serialization;

namespace AWSServerlessComDotNet.Model
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataNascimento { get; set; }
        public static string retornaUsuarios()
        {
            List<Usuarios> usuario = new List<Usuarios>();
            usuario.Add(new Usuarios() { Id = 01, Name = "Fulano de tal", DataNascimento = "1992-04-20" });
            usuario.Add(new Usuarios() { Id = 02, Name = "Seclano de tal", DataNascimento = "1989-02-18" });

            string usuarioJson = JsonSerializer.Serialize(usuario);

            return usuarioJson;
        }
    }
}
