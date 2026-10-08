using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Start a new part at slide 8
var splitter = new SplitPptx("presentation.pptx", new[] { 8 }, SplitMode.Interval);

// Save one document per part
splitter.Save("output/deck.pptx");
