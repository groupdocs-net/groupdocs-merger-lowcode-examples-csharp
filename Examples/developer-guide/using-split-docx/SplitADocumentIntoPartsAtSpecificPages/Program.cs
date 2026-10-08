using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Start a new part at pages 7 and 13
var splitter = new SplitDocx("business-plan.docx", new[] { 7, 13 }, SplitMode.Interval);

// Save one document per part
splitter.Save("output/chapter.docx");
