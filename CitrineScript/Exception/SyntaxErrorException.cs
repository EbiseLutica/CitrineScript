namespace CitrineScript
{
    [System.Serializable]
    public class CompileErrorException : System.Exception
    {
        public CompileErrorException() { }
        public CompileErrorException(string message) : base(message) { }
        public CompileErrorException(string message, System.Exception inner) : base(message, inner) { }
        protected CompileErrorException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}