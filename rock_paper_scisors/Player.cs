public class Player {
    public string? name {get; private set;}
    public uint score {get; set;}

    public Hand hand {get; set;}
    //hand is gonna be set 
    public static Player? none = null;
    public Player(string? n) {
        if(n == null) name = "player";
        name = n;
        score = 0;
    }

}