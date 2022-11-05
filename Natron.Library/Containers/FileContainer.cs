using Natron.Library.Serializers;

namespace Natron.Library.Containers;

public sealed class FileContainer : ContainerBase
{
    public string Path { get; }

    /// <summary>
    /// Indicates whether to overwrite the file or not when more than one serializer is used.
    /// </summary>
    public bool Overwrite { get; }

    public FileContainer(string path, bool overwrite = false)
    {
        Path = path;
        Overwrite = overwrite;
    }

    public override async Task Contain(SerializerBase serializer, string contents)
    {
        var path = Path;

        if (!Overwrite)
        {
            path = System.IO.Path.ChangeExtension(Path, serializer.Extension);
        }

        await File.WriteAllTextAsync(path, contents);
    }
}