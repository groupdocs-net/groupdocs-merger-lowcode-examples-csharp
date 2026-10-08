# Basic Example

The following example appends a 6-slide deck to a 7-slide deck. The presentations are loaded from the current folder, and the merged presentation is saved to the `output` folder.

## Code Example

```csharp
using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Append the documents to the source document
var merger = new JoinPptx("deck-1.pptx", new[] { "deck-2.pptx" }, new JoinOptions());

// Save the merged document
merger.Save("output/merged-deck.pptx");
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `deck-1.pptx`
- `deck-2.pptx`

## Learn More

- [Using JoinPptx to Merge PPTX Documents](https://docs.groupdocs.net/merger/developer-guide/using-join-pptx/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
