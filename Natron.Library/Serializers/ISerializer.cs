namespace Natron.Library.Serializers;

internal interface ISerializer
{
    public string Extension { get; }

    public Task<string> Serialize<T>(T instance) where T : notnull;
}