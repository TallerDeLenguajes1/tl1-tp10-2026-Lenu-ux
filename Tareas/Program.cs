using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json;
using EspacioTarea;
//usar API con HttpClient

List <Tarea> tareas;
tareas=await TareaServices.GetTareas();

foreach (var item in tareas)
{
    Console.WriteLine($"Usuario id:{item.UserId}\n Id:{item.Id}\nTitulo:{item.Titulo}\nEstado:{item.Estado}\n");
}


TareaServices.generarArchivo(tareas);