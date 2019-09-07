﻿
using GroupDocs.Signature.Examples.CSharp.AdvancedUsage;
using GroupDocs.Signature.Examples.CSharp.BasicUsage;
using System;

namespace GroupDocs.Signature.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            // TODO: Reference library from Nuget instead of local path.
            
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Please uncomment the example you want to try out

            #region Quick Start

            QuickStart.SetLicenseFromFile.Run();
            //QuickStart.SetLicenseFromStream.Run();
            //QuickStart.SetMeteredLicense.Run();
            QuickStart.HelloWorld.Run();
            #endregion // Quick Start

            return;
            #region Basic Usage

            #region Common

            GetSupportedFileFormats.Run();
            
            #endregion
            
            #region Document Preview

            GetDocumentInfo.Run();
            GeneratePreview.Run();
            #endregion

            #region Sign document with different signature types

            //Sign document with text signature
            SignWithText.Run();

            //Sign document with image signature
            SignWithImage.Run();

            //Sign document with barcode signature
            SignWithBarcode.Run();

            //Sign document with qr-code signature
            SignWithQRCode.Run();

            //Sign document with digital signature
            //SignWithDigital.Run();

            //Sign document with Stamp signature
            SignWithStamp.Run();

            //Sign image document with metadata signature
            SignImageWithMetadata.Run();

            //Sign pdf document with text signature
            SignPdfWithMetadata.Run();

            //Sign presentation document with text signature
            SignPresentationWithMetadata.Run();

            //Sign spreadsheets document with text signature
            SignSpreadsheetWithMetadata.Run();

            //Sign word-processing document with text signature
            SignWordProcessingWithMetadata.Run();

            //Sign pdf document with form - field signature
            SignPdfWithFormField.Run();

            SignWithMultipleOptions.Run();

            #endregion // Sign document with different signature types

            #region Search signed documents for different signature types

            //Search document for Bar-Code signature
            SearchForBarcode.Run();

            //Search document for QR-Code signature
            SearchForQRCode.Run();

            //Search document for digital signature
            SearchForDigital.Run();

            //Search document for metadata signature
            SearchForMetadata.Run();

            //Search document for form-field signature
            SearchForFormField.Run();

            //Search for signature with multiple options
            SearchForMultiple.Run();

            #endregion // Search signed documents for different signature types

            #region Verify documents signed with different signature types

            //Verify document with Text signature
            VerifyText.Run();

            //Verify document with Bar-Code signature
            VerifyBarcode.Run();

            //Verify document with QR-Code signature
            VerifyQRCode.Run();

            //Verify document with digital signature
            VerifyDigital.Run();

            #endregion // Verify documents signed with different signature types

            #endregion // Basic Usage

            #region Advanced Usage

            #region Loading
            LoadDocumentFromLocalDisk.Run();
            LoadDocumentFromStream.Run();
            LoadDocumentFromUrl.Run();
            //LoadDocumentFromAmazonS3.Run();
            //LoadDocumentFromAzureBlobStorage.Run();
            //LoadDocumentFromFtp.Run();            
            LoadPasswordProtectedDocument.Run();
            
            #endregion

            #region Saving

            SaveSignedPdfWithDifferentOutputFileType.Run();
            SaveSignedSpreadsheetWithDifferentOutputFileType.Run();
            SaveSignedWordProcessingWithDifferentOutputFileType.Run();
            SaveSignedPresentationWithDifferentOutputFileType.Run();
            SaveSignedImageWithDifferentOutputFileType.Run();
            SaveSignedImageWithVariousOutputTypes.Run();

            SaveDocumentWithPassword.Run();
            SaveSignedDocumentsAsImages.Run();            
            #endregion

            #region Sign document with different signature types with additional options

            //Sign document with text signature applying specific options
            SignWithTextAdvanced.Run();

            //Sign document with image signature applying specific options
            SignWithImageAdvanced.Run();

            //Sign document with Bar-Code signature applying specific options
            SignWithBarcodeAdvanced.Run();

            //Sign document with QR-Code signature applying specific options
            SignWithQRCodeAdvanced.Run();

            // Sign Pdf document with Form-fields
            SignPdfWithFormFieldAdvanced.Run();

            SignWithStampAdvanced.Run();
            
            #endregion

            #region Sign QR-Code Encryption, Custom encryption, custom serialization
            SearchForQRCodeEncryptedText.Run();
            SearchForQRCodeEncryptedObject.Run();
            SearchForQRCodeCustomEncryptionObject.Run();
            SearchForQRCodeCustomSerializationObject.Run();
            #endregion

            #region Sign Metadata advanced
            //Sign document with Metadata signature applying specific options
            SignPdfWithStandardMetadata.Run();
            SignPdfWithCustomMetadata.Run();
            SignImageWithCustomMetadata.Run();

            SignWithMetadataEncryptedText.Run();
            SignWithMetadataEncryptedObject.Run();
            SignWithMetadataCustomEncryptionObject.Run();
            SignWithMetadataCustomSerializationObject.Run();
            #endregion

            #region Sign with different annotation
            SignWithPdfTextAnnotation.Run();
            SignWithPdfTextSticker.Run();
            SignWithImageAppearance.Run();
            SignWithDigitalAppearance.Run();

            #endregion

            #region Sign with different measure type
            SignWithMillimeters.Run();
            SignWithPercents.Run();
            SignWithAlignments.Run();
            #endregion

            SignWithStretchMode.Run();

            SignWithExceptionHandling.Run();

            #region Sining with different brush styles
            SignWithSolidBrush.Run();
            SignWithTextureBrush.Run();
            SignWithLinearGradientBrush.Run();
            SignWithRadialGradientBrush.Run();
            #endregion

            #region Search signed documents for different signature types with additional options

            //Search document for Bar-Code signature with applying specific options
            SearchForBarcodeAdvanced.Run();

            //Search document for encrypted QR-Code signature with applying specific options
            SearchForQRCodeAdvanced.Run();

            //Search document for digital signature with applying specific options
            SearchForDigitalAdvanced.Run();

            //Search document for form-field signature with applying specific options
            SearchForFormFieldAdvanced.Run();

            //Search document for metadata signature with applying specific options
            SearchForMetadataAdvanced.Run();

            SearchForMetadataEncryptedText.Run();
            SearchForMetadataEncryptedObject.Run();
            SearchForMetadataCustomEncryptionObject.Run();
            SearchForMetadataCustomSerializationObject.Run();

            SearchWithExceptionHandling.Run();
            #endregion // Search signed documents for different signature types with additional options

            #region Verify signed documents with additional options

            //Verify document with Text signature with applying specific options
            VerifyTextAdvanced.Run();

            //Verify document with Bar-Code signature with applying specific options
            VerifyBarcodeAdvanced.Run();

            //Verify document with QR-Code signature with applying specific options
            VerifyQRCodeAdvanced.Run();

            //Verify document with digital signature with applying specific options
            VerifyDigitalAdvanced.Run();

            #endregion // Verify signed documents with additional options

            #region Subscribing for signing, verification, searching events
            SubscribeSignEvents.Run();
            SubscribeVerifyEvents.Run();
            SubscribeSearchEvents.Run();
            #endregion

            #region Cancellation of signing, verification, searching process
            CancellationSignProcess.Run();
            CancellationVerifyProcess.Run();
            CancellationSearchProcess.Run();
            #endregion

            VerifyWithExceptionHandling.Run();
            #endregion // Advanced Usage

            Console.WriteLine();
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}
