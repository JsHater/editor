using System.Collections.Generic;

namespace WordEditor.Documents.Word
{
    public abstract class ElementContainer : Element
    {
        public List<Element> Elements { get; set; }

        protected ElementContainer()
        {
            Elements = new List<Element>();
        }

        public abstract void AddElement(Element element);

    }
}