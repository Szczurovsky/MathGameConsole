using MathGame.Helpers;
using Spectre.Console;

namespace MathGame.Services
{
    public class GameService : IGameService
    {
        private readonly string[] operationArray = ["Dodawanie", "Odejmowanie", "Mnożenie", "Dzielenie", "Pokaż działania"];

        public void Run()
        {
            var ifContinue = false;
            do
            {
                try
                {
                    var operation = ConsoleWriteMenu();
                    switch (operation)
                    {
                        case "Dodawanie":
                            OperationHelper.MathCalc(operation, '+');
                            break;
                        case "Odejmowanie":
                            OperationHelper.MathCalc(operation, '-');
                            break;
                        case "Mnożenie":
                            OperationHelper.MathCalc(operation, '*');
                            break;
                        case "Dzielenie":
                            OperationHelper.MathCalc(operation, '/');
                            break;
                        case "Pokaż działania":
                            foreach (var item in OperationHelper.tuples)
                            {
                                AnsiConsole.WriteLine($"{item.Item1}: {item.Item2}");
                            }
                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Czy chcesz kontynuować");
                    var ifContinueString = Console.ReadLine();
                    ifContinue = ifContinueString == "tak" ? true : false;
                }
                catch
                {
                    throw new Exception("Can't run your game session");
                }
            }
            while (ifContinue);
        }

        public string ConsoleWriteMenu()
        {
            var operation = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Podaj swoje[red] wymarzone działanie[/]?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Przesuwaj w dół lub w górę aby wybrac działanie)[/]")
                    .AddChoices(operationArray));
            AnsiConsole.WriteLine($"");
            AnsiConsole.WriteLine($"Wybranym przez ciebie działaniem jest: {operation}");
            return operation;
        }
    }
}
