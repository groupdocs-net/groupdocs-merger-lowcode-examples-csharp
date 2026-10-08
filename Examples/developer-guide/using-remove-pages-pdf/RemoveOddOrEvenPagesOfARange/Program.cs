using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Remove the even pages from 1 to 6
var remover = new RemovePagesPdf("business-plan.pdf", new RemoveOptions(1, 6, RangeMode.EvenPages));

// Save the remaining pages
remover.Save("output/without-even-pages.pdf");
