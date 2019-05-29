namespace CitrineScript
{
    public class StringLiteralNode : IExpression
    {
        public string String { get; }
        public StringLiteralNode(string str) => String = str;
    }
}
