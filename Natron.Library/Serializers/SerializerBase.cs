namespace Natron.Library.Serializers;

public abstract class SerializerBase : ISerializer
{
    // Add support for passing settings
    protected SerializerBase()
    {
    }

    public abstract Task<string> Serialize<T>(T instance) where T : notnull;
}