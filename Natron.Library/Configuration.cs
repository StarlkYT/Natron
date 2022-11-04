using Natron.Library.Containers;
using Natron.Library.Serializers;

namespace Natron.Library;

public sealed class Configuration<T> where T : notnull
{
    public T Instance { get; }

    public IContainer Container { get; }

    public ISerializer Serializer { get; }

    internal Configuration(T instance, IContainer container, ISerializer serializer)
    {
        Instance = instance;
        Container = container;
        Serializer = serializer;
    }

    /// <summary>
    /// Serializes and puts all the data in the <see cref="Container"/>. 
    /// </summary>
    public async Task PersistAsync()
    {
        var contents = await Serializer.Serialize(Instance);
        await Container.Contain(contents);
    }
}