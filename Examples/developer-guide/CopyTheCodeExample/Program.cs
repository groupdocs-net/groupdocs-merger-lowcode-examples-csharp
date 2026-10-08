using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Append the cost analysis to the business plan
var merger = new JoinPdf("business-plan.pdf", new[] { "cost-analysis.pdf" }, new JoinOptions());

// Save the merged document
merger.Save("output/business-plan-with-costs.pdf");
