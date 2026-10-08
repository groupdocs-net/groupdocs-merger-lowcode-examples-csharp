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
using var stream = File.OpenRead("chapter-1.docx");

// Append the documents to the source document
var merger = new JoinDocx(stream, new[] { "chapter-2.docx" }, new JoinOptions());

// Save the merged document
merger.Save("output/chapters-1-2.docx");
