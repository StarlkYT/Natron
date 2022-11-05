using Natron.Library.Serializers;

namespace Natron.Library.Containers;

internal interface IContainer
{
    public Task Contain(SerializerBase serializer, string contents);
}