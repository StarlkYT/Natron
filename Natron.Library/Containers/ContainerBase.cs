namespace Natron.Library.Containers;

/// <summary>
/// The base class for containers that are used for persistence.
/// </summary>
public abstract class ContainerBase : IContainer
{
    public abstract Task Contain(string contents);
}