﻿using System;
using System.IO;
using System.Drawing;

namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;
    using GroupDocs.Signature.Domain.Extensions;

    public class SignWithTextureBrush
    {
        /// <summary>
        /// Sign document with text signature applying specific options
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_PDF;
            string fileName = Path.GetFileName(filePath);

            string outputFilePath = Path.Combine(Constants.OutputPath, "SignWithBrushes", "SignedTextureBrush.pdf");

            using (Signature signature = new Signature(filePath))
            {
                TextSignOptions options = new TextSignOptions("John Smith")
                {
                    // adjust signature appearance brush

                    // setup background
                    Background = new Background()
                    {
                        Color = Color.LimeGreen,
                        Transparency = 0.5,
                        Brush = new TextureBrush(Constants.ImageHandwrite)
                    },

                    // locate signature
                    Width = 100,
                    Height = 80,
                    VerticalAlignment = Domain.VerticalAlignment.Center,
                    HorizontalAlignment = Domain.HorizontalAlignment.Center,
                    Margin = new Padding() { Top = 20, Right = 20 },

                    // set alternative signature implementation on document page
                    SignatureImplementation = TextSignatureImplementation.Image

                };

                // sign document to file
                signature.Sign(outputFilePath, options);
            }
            Console.WriteLine("\nSource document signed successfully.\nFile saved at " + outputFilePath);
        }
    }
}