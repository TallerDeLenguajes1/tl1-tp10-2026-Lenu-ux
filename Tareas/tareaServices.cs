using System.Text.Json;
using EspacioTarea;
public static class TareaServices
{
    private static readonly HttpClient client= new HttpClient();
    public static async Task<List<Tarea>> GetTareas()
{
     
    var url= "https://jsonplaceholder.typicode.com/todos/";
    HttpResponseMessage response=await client.GetAsync(url);
    response.EnsureSuccessStatusCode();
    
    string body =await response.Content.ReadAsStringAsync();
    List<Tarea>? listaTarea=JsonSerializer.Deserialize<List<Tarea>>(body);
 
    return listaTarea;



}
public static void generarArchivo(List<Tarea> tareas)
    {
        string json=JsonSerializer.Serialize(tareas);
        File.WriteAllText("tareas.json",json);
    }
}