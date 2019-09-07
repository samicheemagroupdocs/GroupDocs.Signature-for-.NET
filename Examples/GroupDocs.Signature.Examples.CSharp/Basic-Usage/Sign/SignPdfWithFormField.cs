﻿using System;
using System.IO;

namespace GroupDocs.Signature.Examples.CSharp.BasicUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;

    public class SignPdfWithFormField
    {
        /// <summary>
        /// Sign pdf document with form-field signature
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_PDF;
            string fileName = Path.GetFileName(filePath);

            string outputFilePath = Path.Combine(Constants.OutputPath, "SignPdfWithFormField", fileName);

            using (Signature signature = new Signature(filePath))
            {
                // instantiate text form field signature
                FormFieldSignature textSignature = new TextFormFieldSignature("FieldText", "Value1");
                // instantiate options based on text form field signature
                FormFieldSignOptions options = new FormFieldSignOptions(textSignature)
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    Margin = new Padding(10, 20, 0, 0),
                    Height = 10,
                    Width = 100
                };

                // sign document to file
                signature.Sign(outputFilePath, options);
                Console.WriteLine("\nSource document signed successfully.\nFile saved at " + outputFilePath);
            }
        }
    }
}