namespace CitrineScript
{
    public class BlockNode : IStatement
    {
        public IStatement[] Statements { get; }

        public BlockNode(IStatement[] statements) => Statements = statements;
    }
    

}
