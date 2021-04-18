using System.Collections.Generic;

namespace WordEditor.Documents.Word
{
    public class BodyElement : ElementContainer
    {

        public BodyElement()
        {
            
        }

        public override void AddElement(Element element)
        {
            Elements.Add(element);
        }

        public override string Type { get; } = "Body";
    }
}