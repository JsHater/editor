using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WordEditor.Documents.Word;

namespace WordEditor.Documents.Builders
{
    public static class DocxBuilder
    {

        public static WordDocument Build(Stream stream)
        {
            var processingDocument = WordprocessingDocument.Open(stream, false);
            var document = new WordDocument();
            var documentBody = processingDocument.MainDocumentPart.Document.Body;
            ProcessBody(document.Body, documentBody);
            return document;
        }

        private static void ProcessBody(BodyElement bodyElement, Body xmlBody)
        {
            var xmlBodyElements = xmlBody.Elements();
            foreach (var xmlBodyElement in xmlBodyElements)
            {
                if (xmlBodyElement is Paragraph xmlParagraph)
                {
                    var paragraphElement = new ParagraphElement();
                    ProcessParagraph(paragraphElement, xmlParagraph);
                    bodyElement.AddElement(paragraphElement);
                }
            }
        }

        private static void ProcessParagraph(ParagraphElement paragraphElement, Paragraph xmlParagraph)
        {
            var xmlParagraphElements = xmlParagraph.Elements();
            foreach (var xmlParagraphElement in xmlParagraphElements)
            {
                if (xmlParagraphElement is Run run)
                {
                    var xmlRunElements = run.Elements();
                    foreach (var xmlRunElement in xmlRunElements)
                    {
                        if (xmlRunElement is Text text)
                        {
                            var textElement = new TextElement(text.Text);
                            paragraphElement.AddElement(textElement);
                        }
                    }
                }
            }
        }

    }
}