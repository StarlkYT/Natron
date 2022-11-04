using Natron.Library.Containers;

namespace Natron.Library.Builder.Stages;

public interface IContainerSelectionStage<T> where T : notnull
{
    public ISerializerSelectionStage<T> WithContainer(IContainer container);
}