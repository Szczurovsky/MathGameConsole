using MathGame.Helpers;
using Spectre.Console;

namespace MathGame.Services
{
    public class GameService : IGameService
    {

        public void Run()
        {
            var ifContinue = false;
            do
            {
                try
                {
                    OperationHelper.SelectOperationMode();
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

     
    }
}
