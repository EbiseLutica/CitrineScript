namespace CitrineScript
{
    public class WhileNode : IStatement
    {
        public IStatement LoopStatement { get; }
        public IExpression Condition { get; }

        public WhileNode(IStatement loopStatement, IExpression condition)
        {
            LoopStatement = loopStatement;
            Condition = condition;
        }
    }
}
