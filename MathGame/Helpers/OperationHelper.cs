using Spectre.Console;
using System.Reflection.Metadata.Ecma335;

namespace MathGame.Helpers
{
    public class OperationHelper
    {
        public static List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();
        public static bool ifContinue = false;

        public static void MathCalc(string operation, char typeOfOperation)
        {
            do
            {
                AnsiConsole.WriteLine("Podaj dwie liczby z przedziału od 1 do 100");
                Int32.TryParse(Console.ReadLine(), out var firstNumber);
                Int32.TryParse(Console.ReadLine(), out var secondNumber);
                var result = Calculation(typeOfOperation, firstNumber, secondNumber, operation);
                AnsiConsole.Markup($"Rozwiązaniem twojego działania jest: {result}");

            }
            while (ifContinue);
        }
        public static int Calculation(char typeOfOperation, int firstNumber, int secondNumber, string operation)
        {
            var result = 0;

            switch (typeOfOperation)
            {
                case '+':
                     result = firstNumber + secondNumber;
                    tuples.Add(AddToListOfOperations(operation, result));
                    return result;
                case '-':
                     result = firstNumber - secondNumber;
                    tuples.Add(AddToListOfOperations(operation, result));
                    return result;
                case '*':
                    result = firstNumber * secondNumber;
                    tuples.Add(AddToListOfOperations(operation, result));
                    return result;
                case '/':
                    result = firstNumber / secondNumber;
                    var wykonalne = firstNumber % secondNumber;
                    if(wykonalne != 0)
                    {
                        AnsiConsole.WriteLine("Podane liczby są niepodzielne przez siebie!");
                        result = 0;
                    }
                    tuples.Add(AddToListOfOperations(operation, result));
                    return result;
                default: return result;
            }
        }
        private static Tuple<string, int> AddToListOfOperations(string operation, int result)
        {
            return Tuple.Create(operation, result);
        }
    }
}
