using Irony.Parsing;

namespace CitrineScript
{
	[Language("CitrineScript")]
	public class CSGrammar : Grammar
	{
		public CSGrammar()
		{
            // Statement
			var statements = new NonTerminal("statements");
			var statement = new NonTerminal("statement");
			var block = new NonTerminal("block");

            // Comment
            var inlineComment = new CommentTerminal("inlineComment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
            var blockedComment = new CommentTerminal("blockedComment", "/*", "*/");

			NonGrammarTerminals.Add(inlineComment);
			NonGrammarTerminals.Add(blockedComment);

			// Operators
			var plus = ToTerm("+");
			var minus = ToTerm("-");
			var asterisk = ToTerm("*");
			var slash = ToTerm("/");
			var percent = ToTerm("%");
			var equal = ToTerm("=");
			var equal2 = ToTerm("==");
			var notequal = ToTerm("!=");
			var lt = ToTerm("<");
			var gt = ToTerm(">");
			var le = ToTerm("<=");
			var ge = ToTerm(">=");
			var and = ToTerm("&");
			var pipe = ToTerm("|");
			var bang = ToTerm("!");
			var hat = ToTerm("^");
			var opTilde = ToTerm("~");
			var and2 = ToTerm("&&");
			var or2 = ToTerm("||");
			var lt2 = ToTerm("<<");
			var gt2 = ToTerm(">>");
			var plus2 = ToTerm("++");
			var minus2 = ToTerm("--");
			var parenLeft = ToTerm("(");
			var parenRight = ToTerm(")");
			var braceLeft = ToTerm("{");
			var braceRight = ToTerm("}");
			var bracketLeft = ToTerm("[");
			var bracketRight = ToTerm("]");
			var colon = ToTerm(":");
			var comma = ToTerm(",");
			var period = ToTerm(".");
			var semiColon = ToTerm(";");

			// keywords
			var @if = ToTerm("if");
			var @else = ToTerm("else");
			var @for = ToTerm("for");
			var @continue = ToTerm("continue");
			var @break = ToTerm("break");
			var @switch = ToTerm("switch");
			var @case = ToTerm("case");
			var @loop = ToTerm("loop");
			var @return = ToTerm("return");
			var @def = ToTerm("def");
			var @each = ToTerm("each");
			var @in = ToTerm("in");
			var @var = ToTerm("var");
			var @const = ToTerm("const");
			var @null = ToTerm("null");
			var @true = ToTerm("true");
			var @false = ToTerm("false");

			// Value
			var valString = new StringLiteral("string", "\"", StringOptions.AllowsAllEscapes);
			var valNumber = new NumberLiteral("number");
			var valBoolean = new NonTerminal("boolean")
			{
				Rule = @true | @false
			};

			var identifier = new RegexBasedTerminal("identifier", "[a-zA-Z_][a-zA-Z0-9_]*");


			// Expressions

			var expression = new NonTerminal("expression");
			var exprAndOr = new NonTerminal("exprAndOr");
			var exprComparision = new NonTerminal("exprComparision");
			var exprBit = new NonTerminal("exprBit");
			var exprAddSub = new NonTerminal("exprAddSub");
			var exprMulDiv = new NonTerminal("exprMulDiv");
			var exprParen = new NonTerminal("exprParen");
			var exprUnary = new NonTerminal("exprUnary");
			var exprPreIncDec = new NonTerminal("exprPostIncDec");
			var exprPostIncDec = new NonTerminal("exprPostIncDec");
			var exprValue = new NonTerminal("exprValue");

			var exprStatement = new NonTerminal("exprStatement")
			{
				Rule = expression
			};

			// Construct Rules
			statements.Rule = MakeStarRule(statements, statement);
			statement.Rule = exprStatement + semiColon | 
                block;

			block.Rule = braceLeft + statements + braceRight;

			expression.Rule = exprAndOr;

			exprAndOr.Rule = exprComparision |
				exprAndOr + and2 + exprAndOr |
				exprAndOr + or2 + exprAndOr;

			exprComparision.Rule = exprBit |
				exprComparision + equal2 + exprComparision |
				exprComparision + notequal + exprComparision |
				exprComparision + lt + exprComparision |
				exprComparision + gt + exprComparision |
				exprComparision + le + exprComparision |
				exprComparision + ge + exprComparision;

			exprBit.Rule = exprAddSub |
				exprBit + and + exprBit |
				exprBit + pipe + exprBit |
				exprBit + hat + exprBit;

			exprAddSub.Rule = exprMulDiv |
				exprAddSub + plus + exprAddSub |
				exprAddSub + minus + exprAddSub;

			exprMulDiv.Rule = exprParen |
				exprMulDiv + asterisk + exprMulDiv |
				exprMulDiv + slash + exprMulDiv |
				exprMulDiv + percent + exprMulDiv;

			exprParen.Rule = exprUnary |
				parenLeft + expression + parenRight;

			exprUnary.Rule = exprPreIncDec |
				plus + exprUnary |
				minus + exprUnary;

			exprPreIncDec.Rule = exprPostIncDec |
				plus2 + identifier |
				minus2 + identifier;

			exprPostIncDec.Rule = exprValue |
				exprPreIncDec + plus2 |
				exprPreIncDec + plus2;

			exprValue.Rule = valNumber | valString | valBoolean | identifier;

			Root = statements;
		}
	}
}
