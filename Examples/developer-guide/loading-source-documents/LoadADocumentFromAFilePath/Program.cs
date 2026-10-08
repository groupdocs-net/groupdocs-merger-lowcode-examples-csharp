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
