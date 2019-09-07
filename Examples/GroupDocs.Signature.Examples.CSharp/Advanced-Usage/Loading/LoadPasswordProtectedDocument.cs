﻿using System;
using System.IO;

namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;

    public class LoadPasswordProtectedDocument
    {
        /// <summary>
        /// Sign document with qr-code signature
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_SIGNED_PWD_PDF;
            string fileName = Path.GetFileName(filePath);

            string outputFilePath = Path.Combine(Constants.OutputPath, "LoadPasswordProtected", fileName);
            LoadOptions loadOptions = new LoadOptions()
            {
                Password = "1234567890"
            };
            using (Signature signature = new Signature(filePath, loadOptions))
            {
                QrCodeSignOptions options = new QrCodeSignOptions("JohnSmith")
                {
                    EncodeType = QrCodeTypes.QR,
                    Left = 100,
                    Top = 100
                };

                // sign document to file
                signature.Sign(outputFilePath, options);
            }
            Console.WriteLine("\nSource document signed successfully.\nFile saved at " + outputFilePath);
        }
    }
}