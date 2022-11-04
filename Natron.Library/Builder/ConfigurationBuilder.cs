﻿using Natron.Library.Builder.Stages;
using Natron.Library.Containers;
using Natron.Library.Serializers;

namespace Natron.Library.Builder;

/// <summary>
/// Builds an instance of <see cref="Configuration{T}"/>.
/// </summary>
/// <typeparam name="T">The type of the instance to use.</typeparam>
public sealed class ConfigurationBuilder<T> : IContainerSelectionStage<T>, ISerializerSelectionStage<T>, IBuilderInitializerStage<T>
{
    private IContainer? natronContainer;
    private ISerializer? natronSerializer;

    private readonly T natronInstance;

    private ConfigurationBuilder(T instance)
    {
        natronInstance = instance;
    }

    public static IContainerSelectionStage<T> Configure(T instance)
    {
        return new ConfigurationBuilder<T>(instance);
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