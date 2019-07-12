using System;

namespace CitrineScript.Example
{
    class Program
    {
        static void Main(string[] args)
        {
			while (true)
			{
                try
                {
                    Console.Write("> ");
                    new Runtime(Console.ReadLine());
                }
                catch (Exception ex)
                {
					Console.Error.WriteLine($"Unhandled Exception: {ex.GetType().FullName}: {ex.Message}\n{ex.StackTrace}");
				}
			}
		}
    }
}
