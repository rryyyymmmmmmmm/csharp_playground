public class Card {
    public CardColor cardcolor {get;}
    public CardRank cardrank {get;}

    public Card(CardColor cc, CardRank cr) {
        cardcolor = cc;
        cardrank = cr;
    }

    public bool rankIsNumber() {
        if( cardrank == CardRank.Percent ||
            cardrank == CardRank.Amperstand ||
            cardrank == CardRank.Peso ||
            cardrank == CardRank.Caret )
        return false;
        else return true;
    }

    public void displayCard() {
        switch (cardcolor) {
            case CardColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
            break;
            case CardColor.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
            break;
            case CardColor.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
            break;
            case CardColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
            break;
        }
        Console.WriteLine($"The {cardcolor} {cardrank}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void createAllCards() {
        Card[] cards = new Card[14*4];
        for(int i = 0; i < 14; i++) {
            for(int j = 0; j < 4; j++) {
                cards[i*j] = new Card((CardColor)j, (CardRank)i);
                cards[i*j].displayCard();
            }
        }
    }
}

public enum CardRank {One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Percent, Amperstand, Caret, Peso};
public enum CardColor {Red, Green, Blue, Yellow}