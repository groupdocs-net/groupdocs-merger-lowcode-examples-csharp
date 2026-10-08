using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Open the source document as a stream
using var stream = File.OpenRead("business-plan.pdf");

// Remove pages 2 and 4
var remover = new RemovePagesPdf(stream, new RemoveOptions(new[] { 2, 4 }));

// Save the remaining pages
remover.Save("output/trimmed.pdf");
