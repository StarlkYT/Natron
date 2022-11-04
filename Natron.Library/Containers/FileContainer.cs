namespace Natron.Library.Containers;

public sealed class FileContainer : ContainerBase
{
    public string Path { get; }

    public FileContainer(string path)
    {
        Path = path;
    }

    public override async Task Contain(string contents)
    {
        await File.WriteAllTextAsync(Path, contents);
    }
}