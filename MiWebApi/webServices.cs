using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using EspacioWeb;

public static class WebServices
{
    private static readonly HttpClient client=new HttpClient();
    public static async Task<List<Web>> GetWebs()
    {
        var url= "http://universities.hipolabs.com/search?name=middle";

        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string body= await response.Content.ReadAsStringAsync();
        List <Web>? listaweb=JsonSerializer.Deserialize<List<Web>>(body);

        return listaweb;
    }

    public static void generarArchivo(List<Web> webs)
    {
        string json= JsonSerializer.Serialize(webs);
        File.WriteAllText("webs.json",json);
    }
}