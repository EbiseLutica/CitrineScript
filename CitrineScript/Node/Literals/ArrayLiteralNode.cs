namespace CitrineScript
{
    public class ArrayLiteralNode : IExpression
    {
        public IExpression[] Elements { get; }
        public ArrayLiteralNode(IExpression[] elements) => Elements = elements;
    }
}
