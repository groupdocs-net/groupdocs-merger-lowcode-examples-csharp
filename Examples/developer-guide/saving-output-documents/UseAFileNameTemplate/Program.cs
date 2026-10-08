using System;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Select pages 2 and 4
var splitter = new SplitPdf("business-plan.pdf", new[] { 2, 4 });

// Save page-2-of-business-plan.pdf and page-4-of-business-plan.pdf
splitter.Save("output/page-{0}-of-business-plan.pdf");
