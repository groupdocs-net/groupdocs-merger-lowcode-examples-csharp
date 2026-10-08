using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.Exceptions;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

try
{
    // The document has 18 pages
    var remover = new RemovePagesPdf("business-plan.pdf", new RemoveOptions(new[] { 50 }));
    remover.Save("output/trimmed.pdf");
}
catch (GroupDocsMergerException ex)
{
    // Page number more than page count.
    Console.WriteLine(ex.Message);
}
