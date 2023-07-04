using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;

namespace rock_paper_scisors;
public class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        Game[] games = new Game[10];

        while(i < games.Length) {
            
            Console.WriteLine("What is your name? : ");
            string? playername = Console.ReadLine();
            games[i] = new Game(playername, "bot");

            var status = games[i].run();
            if(status == 1) Environment.Exit(status);
            
        }
        
    }
}
