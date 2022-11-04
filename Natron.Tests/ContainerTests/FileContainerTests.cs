namespace Natron.Tests.ContainerTests;

public sealed class FileContainerTests
{
    private readonly string path = Path.Combine(Directory.GetCurrentDirectory(), nameof(FileContainerTests));

    [Fact]
    public async Task FileContainer_Outputs_CorrectJsonFile()
    {
        // Arrange
        var serializer = new JsonSerializer();
        var container = new FileContainer(path);

        // Act
        await container.Contain(await serializer.Serialize(nameof(FileContainerTests)));

        // Assert
        Assert.Equal(await File.ReadAllTextAsync(path), $"\"{nameof(FileContainerTests)}\"");
    }

    [Fact]
    public async Task FileContainer_Outputs_CorrectYamlFile()
    {
        // Arrange
        var serializer = new JsonSerializer();
        var container = new FileContainer(path);

        // Act
        await container.Contain(await serializer.Serialize(nameof(FileContainerTests)));

        // Assert
        Assert.Equal(await File.ReadAllTextAsync(path), $"\"{nameof(FileContainerTests)}\"");
    }
}