using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EspacioWeb;

List <Web> webs;
webs= await WebServices.GetWebs();

foreach (var item in webs)
{
    string pagina= (item.web_pages != null && item.web_pages.Count > 0)? item.web_pages[0] : "N/A";
    string dominio= (item.domains != null && item.domains.Count> 0)? item.domains[0] : "N/A";
    Console.WriteLine($"Pagina web:{pagina}");
    Console.WriteLine($"Nombre:{item.name}");
    Console.WriteLine($"Pais:{item.country}");
    Console.WriteLine($"Alpha two code:{item.alpha_two_code}");
    Console.WriteLine($"Dominio:{dominio}");
    Console.WriteLine($"Provincia:{item.stateprovince ?? "N/A"}");

    
}
WebServices.generarArchivo(webs);
