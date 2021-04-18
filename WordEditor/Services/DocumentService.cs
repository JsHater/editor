using Microsoft.AspNetCore.Http;
using WordEditor.Documents;
using WordEditor.Exceptions;
using WordEditor.Repositories;
using WordEditor.Utils;

namespace WordEditor.Services
{
    public class DocumentService : IDocumentService
    {

        private readonly IDocumentRepository _documentRepository; 
        
        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
        
        public IDocument Create(IFormFile file)
        {
            var type = GetDocType(file);
            using (var stream = file.OpenReadStream())
            {
                var document = DocumentFactory.Create(type, stream);
                return document;
                // return _documentRepository.Save(document);
            }
        }

        private DocumentType GetDocType(IFormFile file)
        {
            var ext = FileUtils.GetFileExtension(file.FileName);
            return ext switch
            {
                "docx" => DocumentType.DOCX,
                _ => throw new UnsupportedDocumentProcessingException($"Document format {ext} not supported")
            };
        }

    }
}