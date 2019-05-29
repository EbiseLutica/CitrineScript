namespace CitrineScript
{
    public class LoopNode : IStatement
    {
        public IStatement LoopStatement { get; }

        public LoopNode(IStatement loopStatement)
        {
            this.LoopStatement = loopStatement;
        }
    }
}
