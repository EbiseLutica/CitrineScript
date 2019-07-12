using System;

namespace CitrineScript
{
    public interface ICommand
    {
        CSValue Run(CSCommandArgs cargs, params CSValue[] args);
    }

    public class NativeCommand : ICommand
    {
        public NativeCommand(Func<CSValue[], CSCommandArgs, CSValue> f)
        {
            func = f;
        }
        public NativeCommand(Action<CSValue[], CSCommandArgs> action)
        {
            func = new Func<CSValue[], CSCommandArgs, CSValue>((args, cargs) => 
            {
                action(args, cargs);
                return CSValue.Void;
            });
        }

        public CSValue Run(CSCommandArgs cargs, params CSValue[] args) => func(args, cargs);

        private Func<CSValue[], CSCommandArgs, CSValue> func;
    }
}