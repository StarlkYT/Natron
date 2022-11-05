using Natron.Library.Builder.Stages;
using Natron.Library.Containers;
using Natron.Library.Serializers;

namespace Natron.Library.Builder;

/// <summary>
/// Builds an instance of <see cref="Configuration{T}"/>.
/// </summary>
/// <typeparam name="T">The type of the instance to use.</typeparam>
public sealed class Natron<T> : IContainerSelectionStage<T>, ISerializerSelectionStage<T>, IBuilderInitializerStage<T>
    where T : notnull
{
    private ContainerBase[]? natronContainers;
    private SerializerBase[]? natronSerializers;

    private readonly T natronInstance;

    private Natron(T instance)
    {
        natronInstance = instance;
    }

    public static IContainerSelectionStage<T> Configure(T instance)
    {
        return new Natron<T>(instance);
    }

    public ISerializerSelectionStage<T> UseContainers(Func<ContainerBase[]> containers)
    {
        natronContainers = containers();
        return this;
    }

    public IBuilderInitializerStage<T> UseSerializers(Func<SerializerBase[]> serializers)
    {
        natronSerializers = serializers();
        return this;
    }

    public Configuration<T> Build()
    {
        ArgumentNullException.ThrowIfNull(natronContainers);
        ArgumentNullException.ThrowIfNull(natronSerializers);

        return new Configuration<T>(natronInstance, natronContainers, natronSerializers);
    }
}