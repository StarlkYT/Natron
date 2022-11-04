namespace Natron.Library.Containers;

public sealed class FileContainer : ContainerBase
{
    public FileContainer(string path) : base(path)
    {
    }

    public override async Task Contain(string contents)
    {
        await File.WriteAllTextAsync(Path, contents);
    }
}