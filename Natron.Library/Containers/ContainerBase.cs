using Natron.Library.Serializers;

namespace Natron.Library.Containers;

/// <summary>
/// The base class for all containers that are used for data persistence.
/// </summary>
public abstract class ContainerBase : IContainer
{
    public abstract Task Contain(SerializerBase serializer, string contents);
}