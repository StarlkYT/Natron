namespace Natron.Library.Serializers;

public abstract class SerializerBase : ISerializer
{
    public abstract string Extension { get; }

    public abstract Task<string> Serialize<T>(T instance) where T : notnull;
}