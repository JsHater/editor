using WordEditor.Documents.Word;

namespace WordEditor.Documents
{
    public class WordDocument : IDocument
    {

        public BodyElement Body { get; set; }

        public WordDocument()
        {
            Body = new BodyElement();
        }
        
    }
}