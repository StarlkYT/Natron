namespace Natron.Tests.ContainerTests;

public sealed class FileContainerTests
{
    private readonly string path = Path.Combine(Directory.GetCurrentDirectory(), nameof(FileContainerTests));

    [Fact]
    public async Task FileContainer_Outputs_CorrectJsonFile()
    {
        // Arrange
        var serializer = new JsonSerializer();
        var container = new FileContainer($"{path}.{serializer.Extension}");

        // Act
        await container.Contain(serializer, await serializer.Serialize(nameof(FileContainerTests)));

        // Assert
        Assert.Equal($"\"{nameof(FileContainerTests)}\"", await File.ReadAllTextAsync($"{path}.{serializer.Extension}"));
    }

    [Fact]
    public async Task FileContainer_Outputs_CorrectYamlFile()
    {
        // Arrange
        var serializer = new YamlSerializer();
        var container = new FileContainer($"{path}.{serializer.Extension}");

        // Act
        await container.Contain(serializer, await serializer.Serialize(nameof(FileContainerTests)));

        // Assert
        Assert.Equal($"{nameof(FileContainerTests)}\r\n", await File.ReadAllTextAsync($"{path}.{serializer.Extension}"));
    }
}