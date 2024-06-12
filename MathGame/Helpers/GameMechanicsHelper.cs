using System;
using System.Diagnostics;
using Spectre.Console;

namespace MathGame.Helpers
{
    public class GameMechanicsHelper
    {
        public static int timeForMove = 5;

        public static int setTimeForMove()
        {
            AnsiConsole.WriteLine("Wybierz czas ktory chcesz mieć na wykonanie ruchu");
            Int32.TryParse(Console.ReadLine(), out timeForMove);
            return timeForMove;
        }

        public async static Task Game()
        {
            AnsiConsole.WriteLine("Witaj graczu. Postanowiłeś wykazać się zdolnosciami szybkiego liczenia.");
            AnsiConsole.WriteLine("Powodzenia!");
            var timeForMove = setTimeForMove();
            OperationHelper.SelectOperationMode(true);
            Stopwatch sw = Stopwatch.StartNew();
            //zrobic nowa metode odpowiedzialna za gre tylko i wylacznei, kod nie moze byc reuzywalny
            //czas mierzy sie poprawnie
            string odpowiedz = await Task.Run(() => Console.ReadLine());    
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}",
               ts.Minutes, ts.Seconds);
               
            Console.WriteLine("RunTime " + elapsedTime);
        }
      
    }
}

