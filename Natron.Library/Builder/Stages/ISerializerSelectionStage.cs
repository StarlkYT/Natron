using Natron.Library.Serializers;

namespace Natron.Library.Builder.Stages;

public interface ISerializerSelectionStage<T>
{
    public IBuilderInitializerStage<T> WithSerializer(ISerializer serializer);
}