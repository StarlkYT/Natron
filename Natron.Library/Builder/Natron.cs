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
    private IContainer? natronContainer;
    private ISerializer? natronSerializer;

    private readonly T natronInstance;

    private Natron(T instance)
    {
        natronInstance = instance;
    }

    public static IContainerSelectionStage<T> Configure(T instance)
    {
        return new Natron<T>(instance);
    }

    public ISerializerSelectionStage<T> WithContainer(IContainer container)
    {
        natronContainer = container;
        return this;
    }

    public IBuilderInitializerStage<T> WithSerializer(ISerializer serializer)
    {
        natronSerializer = serializer;
        return this;
    }

    public Configuration<T> Build()
    {
        ArgumentNullException.ThrowIfNull(natronContainer);
        ArgumentNullException.ThrowIfNull(natronSerializer);

        return new Configuration<T>(natronInstance, natronContainer, natronSerializer);
    }
}