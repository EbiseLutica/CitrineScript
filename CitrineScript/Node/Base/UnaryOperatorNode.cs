namespace CitrineScript
{
    public abstract class UnaryOperatorNode : IExpression
    {
        public IExpression Child { get; }

        public UnaryOperatorNode(IExpression child) => Child = child;
    }
}
