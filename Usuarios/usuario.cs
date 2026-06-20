using System.Text.Json.Serialization;
namespace EspacioUsuario;
public class Direccion
{
    [JsonPropertyName("street")]
    public string Street { get; set; }
    [JsonPropertyName("suite")]
    public string Suite { get; set; }
    [JsonPropertyName("city")]
    public string City { get; set; }
    [JsonPropertyName("zipcode")]
    public string Zipcode { get; set; }
    [JsonPropertyName("geo")]
    public Geo Geo { get; set; }    
}

public class Company
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("catchPhrase")]
    public string CatchPhrase { get; set; }
    [JsonPropertyName("bs")]
    public string Bs { get; set; }
}

public class Geo
{
    [JsonPropertyName("lat")]
    public string lat{get; set; }
    [JsonPropertyName("lng")]
    public string lng{get; set; }
}

public class Usuario
{
    [JsonPropertyName("id")]
    public int id {get; set; }
    [JsonPropertyName("name")]
    public string name {get; set; }
    [JsonPropertyName("usename")]
    public string username{get; set; }
    [JsonPropertyName("email")]
    public string email{get; set; }

    [JsonPropertyName("address")]
    public Direccion addres {get; set;}

    [JsonPropertyName("phone")]
    public string celular {get; set; }

    [JsonPropertyName("website")]
    public string website {get; set; }

    [JsonPropertyName("company")]
    public Company compania {get; set; }

}
