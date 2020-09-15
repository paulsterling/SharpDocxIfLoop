using SharpDocx;
using SharpDocxIfLoop.Models;
using System;
using System.IO;

namespace SharpDocxIfLoop
{
    class Program
    {
        private static readonly string BasePath =
            Path.GetDirectoryName(typeof(Program).Assembly.Location) + @"/../../..";

        static void Main(string[] args)
        {
            Console.WriteLine("Populating model");
            var model = PopulateModel();

            var viewPath = $"{BasePath}/Templates/IfLoopTests.cs.docx";
            var documentPath = $"{BasePath}/Templates/Output/output.docx";

            try
            {
                Console.WriteLine("Generating docx");
                var document = DocumentFactory.Create(viewPath, model);
                document.Generate(documentPath);

                Console.WriteLine(documentPath);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        private static Loop PopulateModel()
        {
            var modelToRender = new Loop();

            // true
            modelToRender.LoopItems.Add(new IfLoop { ShowText = true, TextContent = "Show this content 1" });
            modelToRender.LoopItems.Add(new IfLoop { ShowText = true, TextContent = "Show this content 2" });
            modelToRender.LoopItems.Add(new IfLoop { ShowText = true, TextContent = "Show this content 3" });

            // false
            modelToRender.LoopItems.Add(new IfLoop { ShowText = false, TextContent = "Hide this content 1" });
            modelToRender.LoopItems.Add(new IfLoop { ShowText = false, TextContent = "Hide this content 2" });
            modelToRender.LoopItems.Add(new IfLoop { ShowText = false, TextContent = "Hide this content 3" });

            return modelToRender;
        }
    }
}
