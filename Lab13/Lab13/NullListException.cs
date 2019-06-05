using System;
using System.Runtime.Serialization;

namespace Lab13
{
    [Serializable]
    internal class NullListException : Exception
    {
        public NullListException()
        {
        }

        public NullListException(string message) : base(message)
        {
        }

        public NullListException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullListException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}