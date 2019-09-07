﻿using System;
using System.IO;
using System.Drawing;

namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;
    using GroupDocs.Signature.Options;
    using GroupDocs.Signature.Domain.Extensions;

    public class SignWithTextAdvanced
    {
        /// <summary>
        /// Sign document with text signature applying specific options
        /// </summary>
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_DOCX;
            string fileName = Path.GetFileName(filePath);

            string outputFilePath = Path.Combine(Constants.OutputPath, "SignWithTextAdvanced", fileName);

            using (Signature signature = new Signature(filePath))
            {
                TextSignOptions options = new TextSignOptions("John Smith")
                {
                    // set signature position 
                    Left = 100,
                    Top = 100,

                    // set signature rectangle
                    Width = 100,
                    Height = 30,

                    // set signature alignment

                    // when VerticalAlignment is set the Top coordinate will be ignored. 
                    // Use Margin properties Top, Bottom to provide vertical offset
                    VerticalAlignment = Domain.VerticalAlignment.Top,

                    // when HorizontalAlignment is set the Left coordinate will be ignored. 
                    // Use Margin properties Left, Right to provide horizontal offset
                    HorizontalAlignment = Domain.HorizontalAlignment.Right,

                    Margin = new Padding() { Top = 20, Right = 20 },

                    // adjust signature appearance

                    // setup signature border
                    Border = new Border()
                    {
                        Color = Color.DarkGreen,
                        DashStyle = DashStyle.DashLongDashDot,
                        Transparency = 0.5,
                        Visible = true,
                        Weight = 2
                    },

                    // set text color and Font
                    ForeColor = Color.Red,
                    Font = new SignatureFont { Size = 12, FamilyName = "Comic Sans MS" },

                    // setup background
                    Background = new Background()
                    {
                        Color = Color.LimeGreen,
                        Transparency = 0.5,
                        Brush = new LinearGradientBrush(Color.LimeGreen, Color.DarkGreen)
                    },

                    // set rotation
                    RotationAngle = 45,

                    // set alternative signature implementation on document page
                    SignatureImplementation = TextSignatureImplementation.Image
                    
                };

                // set up shadow options for text
                TextShadow shadow = new TextShadow();
                shadow.Color = Color.OrangeRed;
                shadow.Angle = 135;
                shadow.Blur = 5;
                shadow.Distance = 4;
                shadow.Transparency = 0.2;

                //add text shadow to signature extensions
                options.Extensions.Add(shadow);

                // sign document to file
                signature.Sign(outputFilePath, options);
            }
            Console.WriteLine("\nSource document signed successfully.\nFile saved at " + outputFilePath);
        }
    }
}
