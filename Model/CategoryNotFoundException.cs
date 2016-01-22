using System;
using System.Runtime.Serialization;

namespace Model
{
    [Serializable]
    public class CategoryNotFoundException : ApplicationException
    {
        public CategoryNotFoundException()
        {
        }

        public CategoryNotFoundException(string message) : base(message)
        {
        }

        public CategoryNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CategoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
