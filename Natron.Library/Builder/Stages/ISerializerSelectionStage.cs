using Natron.Library.Serializers;

namespace Natron.Library.Builder.Stages;

public interface ISerializerSelectionStage<T> where T : notnull
{
    public IBuilderInitializerStage<T> UseSerializers(Func<SerializerBase[]> serializers);
}