public class Round {

    public uint number {get; set;}

    public Round(uint n) {
        number = n;
    }
    //a function that takes a string (that would be read in main through ReadLine) as input, parses it to Hand
    //then returns the hand. 
    public Hand getPlayerHand(string? hand) {
        if(hand == null) return Hand.None;
        hand = hand.ToLower();
        switch (hand) {
            case "rock": return Hand.Rock;            
            case "paper": return Hand.Paper;
            case "scisors": return Hand.Scisors;
            default: return Hand.None;
        }
    }

    private Hand winningHand(Hand hand1, Hand hand2) {
        
        if(hand1 == Hand.None) return hand2;
        if(hand2 == Hand.None) return hand1;

        if(hand1 == Hand.Rock) {
            if(hand2 == Hand.Scisors) return hand1;
            if(hand2 == Hand.Paper) return hand2;
        } else if(hand1 == Hand.Paper) {
            if(hand2 == Hand.Scisors) return hand2;
            if(hand2 == Hand.Rock) return hand1; 
        } else if(hand1 == Hand.Scisors) {
            if(hand2 == Hand.Rock) return hand2;
            if(hand2 == Hand.Paper) return hand1;
        } 

        return Hand.None;
    }
    public Player? roundWinner(Player player1, Player player2) {
        
        var winnerHand = winningHand(player1.hand, player2.hand);
        
        if(winnerHand == Hand.None) return Player.none;

        if(winnerHand == player1.hand) {
            return player1;
        } else if (winnerHand == player2.hand) {
            return player2;
        } else return Player.none;       
    }
}

