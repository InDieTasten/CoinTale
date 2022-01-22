namespace CoinTale
{
    public static class Program
    {
        public static TaleState State;
        public static void Main(string[] args)
        {
            InitializeTerminal();
            DisplayFlashScreen();
            DisplayIntro();
            // TODO DisplayMainMenu();
            // TODO DisplayTutorial();
            State.KeepRunning = true;
            do
            {
                Console.WriteLine("What do you do?");
                Console.Write("> ");
                var userInput = Console.ReadLine();
                if (userInput != null)
                {
                    Command parsedCommand = ParseCommand(userInput);
                    ExecuteCommand(parsedCommand);
                }
                else
                {
                    State.KeepRunning = false;
                }
            }
            while (State.KeepRunning);
            DisplayExitScreen();
        }

        private static void DisplayIntro()
        {
            Console.Clear();
            Console.WriteLine("Here is the games introduction text. TODO fill in with actual intro and add some paging if I'm already at it you know...");
        }

        private static void ExecuteCommand(Command parsedCommand)
        {
            switch (parsedCommand.ParsedVerb)
            {
                case Verb.Exit:
                    Console.WriteLine("Alrighty! See you next time then!");
                    Console.WriteLine("Press ANY key to exit the game.");
                    Console.ReadKey(true);
                    State.KeepRunning = false;
                    break;
                default:
                    Console.WriteLine("We don't do nothing like that our here.");
                    break;
            }
        }

        private static Command ParseCommand(string rawCommandText)
        {
            IEnumerable<string> words = rawCommandText.Split(" ").Where(token => token != string.Empty);

            if (!words.Any())
            {
                return new Command { ParsedVerb = Verb.Nothing };
            }
            var parsedCommand = new Command
            {
                Verb = words.First()
            };
            switch (words.First().ToLower())
            {
                case "look":
                case "see":
                case "watch":
                    parsedCommand.ParsedVerb = Verb.Look;
                    break;
                case "exit":
                case "leave":
                    parsedCommand.ParsedVerb = Verb.Exit;
                    break;
            }
            return parsedCommand;
        }

        private static void DisplayExitScreen()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing Coin Tale! I hope you've enjoyed the stay.");
            Console.WriteLine("To support this project, please consider starring this project on https://github.com/InDieTasten/CoinTale \n");
            Console.WriteLine("Press any key to exit the game.");
            Console.ReadKey(true);
            ExitAlternateScreenBuffer();
        }

        private static void DisplayFlashScreen()
        {
            Console.WriteLine("Coin Tale by InDieTasten (Max Bücker)\n");
            Console.WriteLine("PRESS ANY KEY to start your adventure.");
            Console.ReadKey(true);
        }

        private static void InitializeTerminal()
        {
            Console.Title = "Coin Tale by InDieTasten (Max Bücker)";
            EnterAlternateScreenBuffer();
            //Console.WriteLine("\x1b[38;2;0;255;0m"); // Set text color to #0f0 (green)
        }

        private static void EnterAlternateScreenBuffer() => Console.Write("\x1b[?1049h");
        private static void ExitAlternateScreenBuffer() => Console.Write("\x1b[?1049l");
    }
}