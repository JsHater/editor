namespace WordEditor.Documents.Word
{
    public class ParagraphElement : ElementContainer
    {
        public ParagraphElement()
        {
            
        }

        public override void AddElement(Element element)
        {
            Elements.Add(element);
        }

        public override string Type { get; } = "Paragraph";
    }
}