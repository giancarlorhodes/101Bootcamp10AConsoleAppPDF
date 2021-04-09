using System;
using Shark.PdfConvert;

namespace _101Bootcamp10AConsoleAppPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attempting to create a PDF using Shark.PdfConvert");          
            Console.WriteLine("What is the name for your pdf?");
            string fileName = Console.ReadLine();
            string filePath = @"t:\temp\" + fileName + ".pdf";
            Console.WriteLine("Enter the text for the paragraph tag");
            string paragraphText = Console.ReadLine();
            Console.WriteLine("Enter the text for the h1 tag");
            string h1Text = Console.ReadLine();

            string content = @"<!DOCTYPE html><html><body><h1>" + h1Text + 
                @"</h1><p>" + paragraphText + @"</p></body></html>";

            try
            {

                PdfConvert.Convert(new Shark.PdfConvert.PdfConversionSettings
                {

                    Title = "My First Attempt At Using Shark.PdfConvert",
                    Content = content,
                    OutputPath = filePath

                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // throw;
            }

           

            Console.WriteLine("Converted successfully and PDF is at " + filePath);
            Console.ReadLine();
        }
    }
}
