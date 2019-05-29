using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CitrineScript
{
    public class Runtime
    {
        public List<IExpression> Statements { get; }
        public Dictionary<string, ICommand> Commands { get; }

        protected Runtime(string text)
        {
            
        }

        public static Runtime Parse(string text)
        {
            return new Runtime(text);
        }

        public async Task<object> RunAsync(Stream stdin, Stream stdout, Dictionary<string, object> vars = default)
        {
            vars = vars ?? new Dictionary<string, object>();

            return null;
        }
    }
}
