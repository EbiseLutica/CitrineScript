namespace CitrineScript
{
    public class IfNode : IStatement
    {
        // if と elif の式が配列で入っている
        public IExpression[] Conditions { get; }
        // 上の式の数と、elseがある場合はそれ+1だけの分岐ステートメント。
        // Conditions[0] が true であれば Branches[0] が実行される。
        public IStatement[] Branches { get; }

        public IfNode(IExpression[] conds, IStatement[] branches)
        {
            Conditions = conds;
            Branches = branches;
        }
    }
}
