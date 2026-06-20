using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Linq;
using EspacioUsuario;

List <Usuario> usuarios;
usuarios= await UsuarioServices.GetUsuarios();

foreach (var item in usuarios.Take(5))
{
    Console.WriteLine($"Id: {item.id}");
    Console.WriteLine($"Nombre:{item.name}");
    Console.WriteLine($"Email:{item.email}");
    Console.WriteLine($"Direccion:{item.addres.Street},{item.addres.City}");
    Console.WriteLine($"Telefono:{item.celular}");
    Console.WriteLine($"WebSite:{item.website}");
    Console.WriteLine($"Compania: {item.compania.Name}");
    Console.WriteLine(new string('-',40));

}
UsuarioServices.generarArchivo(usuarios);
