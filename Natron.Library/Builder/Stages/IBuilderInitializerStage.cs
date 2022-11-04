namespace Natron.Library.Builder.Stages;

public interface IBuilderInitializerStage<T> where T : notnull
{
    public Configuration<T> Build();
}