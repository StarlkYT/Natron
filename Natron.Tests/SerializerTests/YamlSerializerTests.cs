namespace Natron.Tests.SerializerTests;

public sealed class YamlSerializerTests
{
    [Fact]
    public async Task YamlSerializer_Outputs_CorrectString()
    {
        // Arrange
        const string instance = nameof(YamlSerializerTests);

        // Act
        var yaml = await new YamlSerializer().Serialize(instance);

        // Assert
        Assert.Equal($"{nameof(YamlSerializerTests)}\r\n", yaml);
    }
}