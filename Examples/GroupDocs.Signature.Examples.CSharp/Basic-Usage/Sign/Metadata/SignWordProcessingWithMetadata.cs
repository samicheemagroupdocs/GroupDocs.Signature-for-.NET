﻿using System;
using System.IO;

namespace GroupDocs.Signature.Examples.CSharp.BasicUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;

    public class SignWordProcessingWithMetadata
    {
        /// <summary>
        /// Sign word-processing document with metadata signature
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_DOCX;
            string fileName = Path.GetFileName(filePath);

            string outputFilePath = Path.Combine(Constants.OutputPath, "SignWordProcessingWithMetadata", fileName);

            using (Signature signature = new Signature(filePath))
            {
                // create Metadata option with predefined Metadata text
                MetadataSignOptions options = new MetadataSignOptions();

                // Create few WordProcessing Metadata signatures
                WordProcessingMetadataSignature[] signatures = new WordProcessingMetadataSignature[]
                {
                    new WordProcessingMetadataSignature("Author", "Mr.Scherlock Holmes"),
                    new WordProcessingMetadataSignature("DateCreated", DateTime.Now),
                    new WordProcessingMetadataSignature("DocumentId", 123456),
                    new WordProcessingMetadataSignature("SignatureId", 123.456M)
                };
                options.Signatures.AddRange(signatures);

                // sign document to file
                signature.Sign(outputFilePath, options);
                Console.WriteLine("\nSource document signed successfully.\nFile saved at " + outputFilePath);
            }
        }
    }
}