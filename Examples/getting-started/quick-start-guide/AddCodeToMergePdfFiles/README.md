# Add Code to Merge PDF Files

Replace the contents of `Program.cs` with the following code. It appends a one-page cost analysis to a business plan:

Copy `business-plan.pdf` and `cost-analysis.pdf` to the project folder.

## Code Example

```csharp
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Copy and paste your license keys
var publicKey = "<your public license key>";
var privateKey = "<your private license key>";

// Set the license
License.Set(publicKey, privateKey);

// Append the cost analysis to the business plan
var merger = new JoinPdf("business-plan.pdf", new[] { "cost-analysis.pdf" }, new JoinOptions());

// Save the merged document
merger.Save("output/business-plan-with-costs.pdf");
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Edit `Program.cs` so that it uses your license: the path to your license file, or your public and private keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `business-plan.pdf`
- `cost-analysis.pdf`

## Learn More

- [Quick Start Guide](https://docs.groupdocs.net/merger/getting-started/quick-start-guide/) in the GroupDocs.Merger.LowCode documentation
- [GroupDocs.Merger.LowCode](https://www.nuget.org/packages/GroupDocs.Merger.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
