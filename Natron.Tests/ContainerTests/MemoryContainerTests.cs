namespace Natron.Tests.ContainerTests;

public sealed class MemoryContainerTests
{
    [Fact]
    public async Task MemoryContainer_Outputs_CorrectJsonFile()
    {
        // Arrange
        var serializer = new JsonSerializer();
        var container = new MemoryContainer(new MemoryStream());

        // Act
        await container.Contain(serializer, await serializer.Serialize(nameof(MemoryContainerTests)));
        container.Stream.Position = 0;

        // Assert
        Assert.Equal(
            await new StreamReader(container.Stream).ReadToEndAsync(),
            $"\"{nameof(MemoryContainerTests)}\"");
    }

    [Fact]
    public async Task MemoryContainer_Outputs_CorrectYamlFile()
    {
        // Arrange
        var serializer = new YamlSerializer();
        var container = new MemoryContainer(new MemoryStream());

        // Act
        await container.Contain(serializer, await serializer.Serialize(nameof(MemoryContainerTests)));
        container.Stream.Position = 0;

        // Assert
        Assert.Equal(
            await new StreamReader(container.Stream).ReadToEndAsync(),
            $"\"{nameof(MemoryContainerTests)}\"");
    }
}