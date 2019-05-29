using System;

namespace CitrineScript
{
    public interface ICommand
    {
        CSValue Run(params CSValue[] args);
    }

    public class NativeCommand : ICommand
    {
        public NativeCommand(Func<CSValue[], CSValue> f)
        {
            func = f;
        }
        public NativeCommand(Action<CSValue[]> action)
        {
            func = new Func<CSValue[], CSValue>(args => 
            {
                action(args);
                return CSValue.Void;
            });
        }

        public CSValue Run(params CSValue[] args) => func(args);

        private Func<CSValue[], CSValue> func;
    }
}