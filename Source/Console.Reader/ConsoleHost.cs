namespace Console.Reader
{
    public class ConsoleHost
    {
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
