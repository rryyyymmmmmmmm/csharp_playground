public class Tile {
    public int number {get; private set;}
    public (int, int) position {get; set;}
    public Tile(int n, (int, int) pos) {
        number = n;
        position = pos;
    }
}