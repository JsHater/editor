using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WordEditor.Documents;
using WordEditor.Services;

namespace WordEditor.Controllers
{
    [ApiController]
    [Route("/document")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService; 
        
        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpPost("/create")]
        public ActionResult<WordDocument> Create(IFormFile file)
        {
            var document = _documentService.Create(file) as WordDocument;
            return Ok(document);
        }
        
    }
}