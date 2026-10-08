using System;
using GroupDocs.Merger.Exceptions;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

try
{
    // A DOCX document passed to the PDF plugin
    var splitter = new SplitPdf("business-plan.docx", new[] { 1 });
    splitter.Save("output/page.pdf");
}
catch (FileTypeNotSupportedException ex)
{
    // Input format does not match the expected format 'PDF'; the supplied file is ...
    Console.WriteLine(ex.Message);
}
