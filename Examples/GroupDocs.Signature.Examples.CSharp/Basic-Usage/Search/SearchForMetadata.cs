using System;
using System.Collections.Generic;

namespace GroupDocs.Signature.Examples.CSharp.BasicUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;


    public class SearchForMetadata
    {
        /// <summary>
        /// Search document for metadata signature
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_PDF_SIGNED;

            using (Signature signature = new Signature(filePath))
            {
                MetadataSearchOptions options = new MetadataSearchOptions()
                {
                    
                };

                // search for signatures in document
                List<MetadataSignature> signatures = signature.Search<MetadataSignature>(options);
                Console.WriteLine("\nSource document contains following signatures.");
                foreach (var metadataSignature in signatures)
                {
                    Console.WriteLine("Metadata signature found. Name : {0}. Value: {1}", metadataSignature.Name, metadataSignature.Value);
                }
            }
        }
    }
}