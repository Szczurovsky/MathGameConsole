using Spectre.Console;

namespace MathGame.Helpers
{
    public static class OperationHelper
    {
        public static void Dodawanie()
        {
            AnsiConsole.WriteLine("Podaj dwie liczby z przedziału od 1 do 100");
            Int32.TryParse(Console.ReadLine(), out var firstNumber);
            Int32.TryParse(Console.ReadLine(), out var secondNumber);
            var result = firstNumber + secondNumber;
            AnsiConsole.Markup($"Rozwiązaniem twojego działania jest: {result}");
        }
        public static void Odejmowanie()
        {

        }
        public static void Mnożenie()
        {

        }
        public static void Dzielenie()
        {

        }
    }
}
