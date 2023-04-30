# Forismatic Client (Motivation Quote C# Client)


Give it a star if you like the project. 👏 🌠 🌟


![Nuget](https://img.shields.io/github/repo-size/purkayasta/ForismaticClient?style=social)
![Nuget](https://img.shields.io/github/last-commit/purkayasta/ForismaticClient?style=flat-square)



# Usage:
### Microsoft DI:

```c#
builder.service.AddForismatic();

public class ApiController {
    private readonly IForismaticApiClient _client;
    public ApiController(IForismaticApiClient client)
        => this._client = client;
}
```

### Factory Pattern:

```c#
IForismaticApiClient client = IForismaticApiClient.CreateClient();
```

### API Example:


```c#
var quote = await client.GetQuoteAsync(Forismatic.Models.LanguageEnum.English);

System.Console.WriteLine(quote.Quote);
System.Console.WriteLine(quote.Author);
System.Console.WriteLine(quote.Link);

```




Made ❤️🔥 with c#