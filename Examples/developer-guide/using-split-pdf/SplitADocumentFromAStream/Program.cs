using System;
using System.IO;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Open the source document as a stream
using var stream = File.OpenRead("business-plan.pdf");

// Select pages 1 and 2
var splitter = new SplitPdf(stream, new[] { 1, 2 });

// Save one document per part
splitter.Save("output/page.pdf");
