using WordEditor.Documents;

namespace WordEditor.Repositories
{
    public interface IDocumentRepository
    {
        int Save(IDocument document);
    }
}