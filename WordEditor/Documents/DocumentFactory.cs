using System.IO;
using WordEditor.Documents.Builders;
using WordEditor.Exceptions;

namespace WordEditor.Documents
{
    public static class DocumentFactory
    {
        public static IDocument Create(DocumentType type, Stream stream)
        {
            return type switch
            {
                DocumentType.DOCX => DocxBuilder.Build(stream),
                _ => throw new UnsupportedDocumentProcessingException("Document not supported")
            };
        }
        
    }
}