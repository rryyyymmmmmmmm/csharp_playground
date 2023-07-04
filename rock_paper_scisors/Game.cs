public class Game {
    Player player1;
    Player player2;

    Round[] rounds = new Round[3];

    public Game(string? player1, string? player2) {
        this.player1 = new Player(player1);
        this.player2 = new Player(player2);
    }

    private void addScore(Round round) {
        var winner = round.roundWinner(player1, player2);
        if(!(winner == Player.none)) winner.score++;
    }

    public int run() {
        rounds[0] = new Round(1);
        rounds[1] = new Round(2);
        rounds[2] = new Round(3);

        foreach (Round currentRound in rounds) {
            var random = new Random();
            var randomHand = (Hand)random.Next(1, 4);

            Console.WriteLine("This is a game of Rock, Paper and Scisors!\n");
            Console.WriteLine($"Round {currentRound.number}");
            Console.WriteLine($"What hand do you want to play, {player1.name}? :");
            string? playerHand = Console.ReadLine();

            if(playerHand == "x") return 1;

            player1.hand = currentRound.getPlayerHand(playerHand);
            player2.hand = randomHand;

            Console.WriteLine($"You played {player1.hand}, {player2.name} played {player2.hand}");

            var roundWinner = currentRound.roundWinner(player1, player2);
            if(roundWinner == Player.none) Console.WriteLine("This round's a draw. No one wins.");
            else Console.WriteLine($"This round's winner is : {roundWinner.name}");
            
            addScore(currentRound);

            Console.ReadKey(false);
            Console.Clear();
            
            Console.WriteLine($"Current score is : {player1.name} : {player1.score} points");
            Console.WriteLine($"                   {player2.name} : {player2.score} points");
        }   
        return 0;
    }
}