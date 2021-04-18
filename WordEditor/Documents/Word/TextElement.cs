namespace WordEditor.Documents.Word
{
    public class TextElement : Element {

        public string Txt { get; set; }

        public TextElement(string text)
        {
            Txt = text;
        }

        public override string Type { get; } = "Text";
    }
}