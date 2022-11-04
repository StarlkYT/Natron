namespace Natron.Library.Serializers;

public sealed class JsonSerializer : SerializerBase
{
    public override Task<string> Serialize<T>(T instance)
    {
        return Task.FromResult(System.Text.Json.JsonSerializer.Serialize(instance));
    }
}