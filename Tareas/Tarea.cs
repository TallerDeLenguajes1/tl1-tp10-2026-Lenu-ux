using System.Text.Json.Serialization;
namespace EspacioTarea;

public class Tarea
{
    private int userId;
    private int id;
    private string? titulo;
    private bool estado;

    [JsonPropertyName("userId")]
    public int UserId { get => userId; set => userId = value; }
    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("titulo")]
    public string? Titulo { get => titulo; set => titulo = value; }
    [JsonPropertyName("estado")]
    public bool Estado { get => estado; set => estado = value; }
}