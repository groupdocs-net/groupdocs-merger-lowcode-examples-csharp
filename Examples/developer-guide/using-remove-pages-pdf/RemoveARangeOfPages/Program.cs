using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Remove pages 15 to 18
var remover = new RemovePagesPdf("business-plan.pdf", new RemoveOptions(15, 18));

// Save the remaining pages
remover.Save("output/without-appendix.pdf");
