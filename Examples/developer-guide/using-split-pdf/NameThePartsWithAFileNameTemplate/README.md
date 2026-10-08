# Name the Parts with a File Name Template

When the output file name contains `{0}`, the part number replaces it instead of being added at the end. The following example produces `business-plan-page-1.pdf` and `business-plan-page-2.pdf`.

## Code Example

```csharp
using System;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Select pages 1 and 2
var splitter = new SplitPdf("business-plan.pdf", new[] { 1, 2 });

// Save one document per part
splitter.Save("output/business-plan-page-{0}.pdf");
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

- [Using SplitPdf to Split PDF Documents](https://docs.groupdocs.net/merger/developer-guide/using-split-pdf/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
