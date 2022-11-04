namespace Natron.Library.Containers;

public interface IContainer
{
    public Task Contain(string contents);
}