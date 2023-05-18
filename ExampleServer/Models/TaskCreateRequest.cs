// Define what the request body for creating tastks should look like
// When the client sends information to the server, this is the object

using System.Text.Json.Serialization;

namespace ExampleServer.Models;

public class TaskCreateRequest 
{   

        [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("description")]

    public string? Description { get; set;}

}