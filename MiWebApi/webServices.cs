using System.Text.Json;
using EspacioWeb;

public static class WebServices
{
    private static readonly HttpClient client=new HttpClient();
    public static async Task<List<Webs>> GetWebs()
    {
        var url= "http://universities.hipolabs.com/search?name=middle";

        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string body= await response.Content.ReadAsStringAsync();
        List <Webs>? listaweb=JsonSerializer.Deserialize<List<Webs>>(body);

        return listaweb;
    }
}