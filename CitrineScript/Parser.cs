using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Irony.Parsing;

namespace CitrineScript
{
	public class Runtime
    {
        public List<IStatement> Statements { get; }
        public Dictionary<string, ICommand> Commands { get; }
        public bool IsRunning { get; protected set; }
        public bool IsStrictMode;
        public bool Is;
        public int LineNumber;

        public Runtime(string code)
        {
			var grammar = new CSGrammar();
			var lang = new LanguageData(grammar);
			var parsed = new Parser(lang).Parse(code);
            if (parsed.HasErrors())
				Console.WriteLine("ERROR!!!!");
            else
				Dump(parsed.Root);
		}

		public void Dump(ParseTreeNode node, int tabLevel = 0)
		{
            Console.WriteLine($"{new string('-', tabLevel)} {node.ToString()}: {node.Token?.ValueString ?? ""}");
			foreach (var child in node.ChildNodes)
			{
				Dump(child, tabLevel + 1);
			}
		}

		public void RegisterCommand()
        {
            Commands["print"] = new NativeCommand((args, cargs) =>
            {
                if (args.Length != 1)
                    throw Error("Argument Mismatch");
                string output;
                switch (args[0].Type)
                {
                    case CSValueType.Number:
                        output = args[0].ToString();
                        break;
                    case CSValueType.String:
                        output = (string)args[0].NativeValue;
                        break;
                    default:
                        throw Error("Type Mismatch");
                }
            });
        }

        public Exception Error(string message) => new RuntimeException(message);
        public Exception CompileError(string message) => new CompileErrorException(message);

        public async Task<object> RunAsync(Stream stdin, Stream stdout, Dictionary<string, object> vars = default)
        {
            if (IsRunning)
                return null;
            IsRunning = true;
            vars = vars ?? new Dictionary<string, object>();
            LineNumber = 0;
            IsRunning = false;
            return null;
        }
    }
}
