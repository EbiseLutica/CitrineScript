namespace CitrineScript
{
    public class FunctionCallNode : IExpression, IStatement
    {
        public string Name { get; }
        public IExpression[] Args { get; }

        public FunctionCallNode(string name, IExpression[] args)
        {
            Name = name;
            Args = args;
        }
    }
    

}
