using WordEditor.Documents;

namespace WordEditor.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        public int Save(IDocument document)
        {
            return 1;
        }
    }
}