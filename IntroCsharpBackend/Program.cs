//12 - Serialización y deserialización de objetos (JSON)

using System.Text.Json;

var diego = new People()
{
    Name = "Diego",
    Age = 36,
};

People.Get();

string json = JsonSerializer.Serialize(diego);

Console.WriteLine(json);

string myJson = @"{
    ""Name"":""Juan"",
    ""Age"":36
}";


People? juan = JsonSerializer.Deserialize<People>(myJson);

Console.WriteLine(juan?.Name);
Console.WriteLine(juan?.Age);

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static string Get() => "Hola";
}

