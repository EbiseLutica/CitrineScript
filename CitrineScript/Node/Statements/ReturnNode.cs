namespace CitrineScript
{
    public class ReturnNode : IStatement
    {
        public IExpression ReturnValue { get; }
        public ReturnNode(IExpression returnValue) => ReturnValue = returnValue;
    }
}
