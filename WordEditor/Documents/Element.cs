using JsonSubTypes;
using Newtonsoft.Json;
using WordEditor.Documents.Word;

namespace WordEditor.Documents
{
    
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(ParagraphElement), "Paragraph")]
    [JsonSubtypes.KnownSubType(typeof(TextElement), "Text")]
    public abstract class Element
    {
        
        public abstract string Type { get; }

        protected Element()
        {
            
        }
        
    }
}