namespace CitrineScript
{
    public class NumberNode : IExpression
    {
        public double Number { get; }
        public NumberNode(double number) => Number = number;
    }
}
