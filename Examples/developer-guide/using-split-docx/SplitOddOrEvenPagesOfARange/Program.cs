using System;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.LowCode;

// Load license keys
var publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY");
var privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY");

// Apply the license
License.Set(publicKey, privateKey);

// Select the even pages from 1 to 6
var splitter = new SplitDocx("business-plan.docx", 1, 6, RangeMode.EvenPages);

// Save one document per part
splitter.Save("output/even-page.docx");
