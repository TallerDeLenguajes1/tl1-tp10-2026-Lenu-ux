namespace EspacioTarea;
public class Tarea
{
    private int userId;
    private int id;
    private string? titulo;
    private bool estado;

    public int UserId { get => userId; set => userId = value; }
    public int Id { get => id; set => id = value; }
    public string? Titulo { get => titulo; set => titulo = value; }
    public bool Estado { get => estado; set => estado = value; }
}