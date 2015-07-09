using System.IO;

namespace Console.Reader
{
    public class ConsoleHost
    {
        private readonly TextReader _textReader;
        private readonly TextWriter _textWriter;

        public ConsoleHost(TextReader textReader, TextWriter textWriter)
        {
            textReader = _textReader;
            textWriter = _textWriter;
        }
        public void Run()
        {


        }

        private void InitConsoleWindow()
        {
            System.Console.SetWindowPosition(0, 0);
            System.Console.Title = "Umbraco Sync Console";
            System.Console.WindowWidth = 170;
            System.Console.WindowHeight = 75;
        }
    }
}
