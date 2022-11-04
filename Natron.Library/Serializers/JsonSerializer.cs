using System.Text.Json;

namespace Natron.Library.Serializers;

public sealed class JsonSerializer : SerializerBase
{
    public JsonSerializerOptions? Options { get; set; }

    public JsonSerializer(JsonSerializerOptions options)
    {
        Options = options;
    }

    public JsonSerializer()
    {
    }
    
    public override Task<string> Serialize<T>(T instance)
    {
        return Task.FromResult(System.Text.Json.JsonSerializer.Serialize(instance, Options));
    }
}