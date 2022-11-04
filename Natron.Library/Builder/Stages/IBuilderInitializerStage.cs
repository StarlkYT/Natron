namespace Natron.Library.Builder.Stages;

public interface IBuilderInitializerStage<T>
{
    public Configuration<T> Build();
}