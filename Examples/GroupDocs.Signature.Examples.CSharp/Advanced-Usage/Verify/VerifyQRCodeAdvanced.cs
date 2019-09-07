﻿using System;

namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;


    public class VerifyQRCodeAdvanced
    {
        /// <summary>
        /// Verify document with QR-Code signature with applying specific options
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_PDF_SIGNED;

            using (Signature signature = new Signature(filePath))
            {
                QrCodeVerifyOptions options = new QrCodeVerifyOptions()
                {
                    // specify if all pages shoudl be verified
                    AllPages = false,
                    PagesSetup = new PagesSetup() {  FirstPage = false, LastPage = true, OddPages = false, EvenPages = true },
                    // specify text pattern
                    Text = "John",
                    // specify verification text pattern
                    MatchType = TextMatchType.Contains,
                    // specify types of QR code to verify
                    EncodeType = QrCodeTypes.QR
                };
                // verify document signatures

                VerificationResult result = signature.Verify(options);
                if (result.IsValid)
                {
                    Console.WriteLine("\nDocument was verified successfully!");
                }
                else
                {
                    Console.WriteLine("\nDocument failed verification process.");
                }
            }
        }
    }
}