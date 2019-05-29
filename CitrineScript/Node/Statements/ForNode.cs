namespace CitrineScript
{
    public class ForNode : IStatement
    {
        public IStatement InitialStatement { get; }
        public IExpression Condition { get; }
        public IStatement LoopStatement { get; }
        public IStatement FinalStatement { get; }

        public ForNode(IStatement initialStatement, IExpression condition, IStatement loopStatement, IStatement finalStatement)
        {
            InitialStatement = initialStatement;
            Condition = condition;
            LoopStatement = loopStatement;
            FinalStatement = finalStatement;
        }
    }
}
