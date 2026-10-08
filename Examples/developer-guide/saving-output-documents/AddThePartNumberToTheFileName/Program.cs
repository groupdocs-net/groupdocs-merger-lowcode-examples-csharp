using System;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Select pages 2 and 4
var splitter = new SplitPdf("business-plan.pdf", new[] { 2, 4 });

// Save business-plan_2.pdf and business-plan_4.pdf
splitter.Save("output/business-plan.pdf");
