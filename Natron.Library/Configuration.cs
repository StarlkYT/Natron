using Natron.Library.Containers;
using Natron.Library.Serializers;

namespace Natron.Library;

public sealed class Configuration<T> where T : notnull
{
    public T Instance { get; }

    public ContainerBase[] Containers { get; }

    public SerializerBase[] Serializers { get; }

    internal Configuration(T instance, ContainerBase[] containers, SerializerBase[] serializers)
    {
        Instance = instance;
        Containers = containers;
        Serializers = serializers;
    }

    /// <summary>
    /// Serializes and puts all the data in the <see cref="Containers"/>.
    /// </summary>
    public async Task PersistAsync()
    {
        foreach (var container in Containers)
        {
            foreach (var serializer in Serializers)
            {
                await container.Contain(serializer, await serializer.Serialize(Instance));
            }
        }
    }
}