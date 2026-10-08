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
