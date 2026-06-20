using System.Text.Json;
using EspacioUsuario;

public static class UsuarioServices
{
    private static readonly HttpClient client= new HttpClient();

    public static async Task<List<Usuario>> GetUsuarios()
    {
        var url = "https://jsonplaceholder.typicode.com/users";
        HttpResponseMessage response= await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        string body=await response.Content.ReadAsStringAsync();
        List<Usuario>? listaUsuario=JsonSerializer.Deserialize<List<Usuario>>(body);

        return listaUsuario;

    }

    //serialisar
public static void generarArchivo(List<Usuario> usuarios)
{
    string json= JsonSerializer.Serialize(usuarios);
    File.WriteAllText("usuarios.json",json);
}
}

