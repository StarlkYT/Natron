namespace Natron.Library.Serializers;

public interface ISerializer
{
    public Task<string> Serialize<T>(T instance) where T : notnull;
}