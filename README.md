# Quick Start
Natron does not have a NuGet package \*yet\*\
Clone and reference the class library project inside your project.

## Usage Example
Natron provides simple and straight-forward usage API.
More advanced features are cooming soon.

```cs
using Natron.Library.Builder;
using Natron.Library.Containers;
using Natron.Library.Serializers;

var account = new Account("Starlk");

var path = Path.Combine(Directory.GetCurrentDirectory(), "account.json");

var configuration = Natron<Account>.Configure(account)
    .WithContainer(new FileContainer(path))
    .WithSerializer(new JsonSerializer())
    .Build();

account.Name = "John";

await configuration.PersistAsync();

internal sealed class Account
{
    public string Name { get; set; }

    public Account(string name)
    {
        Name = name;
    }
}
```

This sample serializes saves the account class instance into a JSON file.

```json
{"Name":"John"}
```
