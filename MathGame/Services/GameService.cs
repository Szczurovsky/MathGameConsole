using MathGame.Helpers;
using Spectre.Console;

namespace MathGame.Services
{
    public class GameService : IGameService
    {
        private readonly string[] operationArray = ["Dodawanie", "Odejmowanie", "Mnożenie", "Dzielenie"];
        public GameService() { }

        public void Run()
        {
            try
            {
                var operation = ConsoleWriteMenu();
                switch(operation)
                {
                    case "Dodawanie":
                        OperationHelper.Dodawanie();
                        break;
                    case "Odejmowanie":
                        break;
                    case "Mnożenie":
                        break;
                    case "Dzielenie":
                        break;
                }
            }
            catch 
            {
                throw new Exception("Can't run your game session");
            }
        }

        public string ConsoleWriteMenu()
        {
            var operation = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Podaj swoje[green] wymarzone działanie[/]?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Przesuwaj w dół lub w górę aby wybrac działanie)[/]")
                    .AddChoices(operationArray));

            AnsiConsole.WriteLine($"Wybranym przez ciebie działaniem jest: {operation}");
            return operation;
        }
    }
}
