using System;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Select slides 2 to 4
var splitter = new SplitPptx("presentation.pptx", 2, 4);

// Save one document per part
splitter.Save("output/slide.pptx");
