using MathGame.Services;

namespace MathGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameService service = new GameService();
            service.Run();
        }
    }
}
