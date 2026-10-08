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
