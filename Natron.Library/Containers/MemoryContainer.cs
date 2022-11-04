using System.Text;

namespace Natron.Library.Containers;

public sealed class MemoryContainer : ContainerBase
{
    public MemoryStream Stream { get; }

    public MemoryContainer(MemoryStream stream)
    {
        Stream = stream;
    }
    
    public override async Task Contain(string contents)
    {
        var stream = new MemoryStream();
        await stream.WriteAsync(Encoding.ASCII.GetBytes(contents));
        stream.WriteTo(Stream);
    }
}