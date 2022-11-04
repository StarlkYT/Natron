namespace Natron.Library.Containers;

/// <summary>
/// The base class for containers that are used for persistence.
/// </summary>
public abstract class ContainerBase : IContainer
{
    protected string Path { get; }

    protected ContainerBase(string path)
    {
        Path = path;
    }

    public abstract Task Contain(string contents);
}