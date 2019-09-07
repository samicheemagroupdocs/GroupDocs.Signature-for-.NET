﻿using System;
using System.IO;
using System.Drawing;

namespace GroupDocs.Signature.Examples.CSharp.BasicUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;

    public class SignWithStamp
    {
        /// <summary>
        /// Sign document with stamp signature
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.            
            string filePath = Constants.SAMPLE_DOCX;
            string fileName = Path.GetFileName(filePath);

            string outputFilePath = Path.Combine(Constants.OutputPath, "SignWithStamp", fileName);

            using (Signature signature = new Signature(filePath))
            {
                StampSignOptions options = new StampSignOptions()
                {
                    // set stamp signature position
                    Left = 100,
                    Top = 100,
                };

                // setup first external line of Stamp
                StampLine outerLine = new StampLine();
                outerLine.Text = " * European Union * European Union  * European Union  * European Union  * European Union  * ";
                outerLine.Font.Size = 12;
                outerLine.Height = 22;
                outerLine.TextBottomIntent = 6;
                outerLine.TextColor = Color.WhiteSmoke;
                outerLine.BackgroundColor = Color.DarkSlateBlue;
                options.OuterLines.Add(outerLine);

                //Inner square lines - horizontal lines inside the rings
                StampLine innerLine = new StampLine();
                innerLine.Text = "John";
                innerLine.TextColor = Color.MediumVioletRed;
                innerLine.Font.Size = 20;
                innerLine.Font.Bold = true;
                innerLine.Height = 40;
                options.InnerLines.Add(innerLine);

                //
                signature.Sign(outputFilePath, options);
            }

            Console.WriteLine("\nSource document signed successfully.\nFile saved at " + outputFilePath);
        }
    }
}
