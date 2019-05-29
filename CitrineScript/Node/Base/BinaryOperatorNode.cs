namespace CitrineScript
{
    public abstract class BinaryOperatorNode : IExpression
    {
        public IExpression Left { get; }
        public IExpression Right { get; }

        public BinaryOperatorNode(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }
    }
}
