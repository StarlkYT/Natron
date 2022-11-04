using Natron.Library.Containers;

namespace Natron.Library.Builder.Stages;

public interface IContainerSelectionStage<T>
{
    public ISerializerSelectionStage<T> WithContainer(IContainer container);
}