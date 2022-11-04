using YamlDotNet.Serialization;

namespace Natron.Library.Serializers;

public sealed class YamlSerializer : SerializerBase
{
    public YamlDotNet.Serialization.ISerializer? Serializer { get; set; }

    public YamlSerializer(YamlDotNet.Serialization.ISerializer serializer)
    {
        Serializer = serializer;
    }

    public YamlSerializer()
    {
    }

    public override Task<string> Serialize<T>(T instance)
    {
        var serializer = Serializer ?? new SerializerBuilder().Build();
        return Task.FromResult(serializer.Serialize(instance));
    }
}