namespace CitrineScript
{
    public class VariableNode : IExpression
    {
        public string Name { get; }
        public VariableNode(string name) => Name = name;
    }
}
