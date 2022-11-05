namespace Natron.Tests.SerializerTests;

public sealed class JsonSerializerTests
{
    [Fact]
    public async Task JsonSerializer_Outputs_CorrectString()
    {
        // Arrange
        const string instance = nameof(JsonSerializerTests);

        // Act
        var json = await new JsonSerializer().Serialize(instance);

        // Assert
        Assert.Equal($"\"{nameof(JsonSerializerTests)}\"", json);
    }
}