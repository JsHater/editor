using Microsoft.AspNetCore.Http;
using WordEditor.Documents;

namespace WordEditor.Services
{
    public interface IDocumentService
    {
        
        IDocument Create(IFormFile file);
        
    }
}