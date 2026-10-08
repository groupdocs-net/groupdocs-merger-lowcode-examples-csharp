# Load a Document from a File Path

Pass the path of the source document. A relative path is resolved against the current directory. The following example splits out the first two pages of a PDF document loaded from a file.

## Code Example

```csharp
using System;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Load the source document from a file path
var splitter = new SplitPdf("business-plan.pdf", new[] { 1, 2 });

// Save one document per page
splitter.Save("output/page.pdf");
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

- [Loading Source Documents](https://docs.groupdocs.net/merger/developer-guide/loading-source-documents/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
