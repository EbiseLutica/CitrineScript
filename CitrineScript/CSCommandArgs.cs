using System.IO;

namespace CitrineScript
{
    public class CSCommandArgs
    {
        public Stream Input { get; }
        public Stream Output { get; }
        public int LineNumber { get; }
        
        public CSCommandArgs(Stream input, Stream output)
        {
            this.Input = input;
            this.Output = output;
        }
    }
}
