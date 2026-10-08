# Handle Invalid Page Numbers

The following example tries to remove a page that doesn't exist.

## Code Example

```csharp
using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.Exceptions;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

try
{
    // The document has 18 pages
    var remover = new RemovePagesPdf("business-plan.pdf", new RemoveOptions(new[] { 50 }));
    remover.Save("output/trimmed.pdf");
}
catch (GroupDocsMergerException ex)
{
    // Page number more than page count.
    Console.WriteLine(ex.Message);
}
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `business-plan.pdf`

## Learn More

- [Handling Errors](https://docs.groupdocs.net/merger/developer-guide/handling-errors/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
