namespace CitrineScript
{
    public class IndexNode
    {
        public IExpression Node { get; }
        public IExpression[] Indexes { get; }
        public IndexNode(IExpression node, IExpression[] indexes)
        { 
            Node = node;
            Indexes = indexes;
        }
    }
}
