using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Append the second chapter to the first one
var merger = new JoinPdf("chapter-1.pdf", new[] { "chapter-2.pdf" }, new JoinOptions());

// Save to a folder that doesn't exist yet
merger.Save("output/merged/chapters-1-2.pdf");
