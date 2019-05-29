namespace CitrineScript
{
    public class FunctionDefineNode : IStatement
    {
        public string Name { get; }
        public IExpression[] Args { get; }
        public BlockNode Block { get; }

        public FunctionDefineNode(string name, IExpression[] args, BlockNode block)
        {
            Name = name;
            Args = args;
            Block = block;
        }
    }
    

}
