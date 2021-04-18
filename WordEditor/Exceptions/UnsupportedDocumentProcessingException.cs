using System;

namespace WordEditor.Exceptions
{
    public class UnsupportedDocumentProcessingException : Exception
    {

        public UnsupportedDocumentProcessingException()
        {
            
        }

        public UnsupportedDocumentProcessingException(string message) : base(message)
        {
            
        }

        public UnsupportedDocumentProcessingException(string message, Exception inner) : base(message, inner)
        {
            
        }

    }
}