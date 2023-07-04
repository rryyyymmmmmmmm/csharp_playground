public class Point {
    public int x {get; set;}
    public int y {get; set;}

    public void updateCoordinates(int x, int y) {
        this.x = x;
        this.y = y;
    }
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
    public Point() { x = 0; y = 0; }

    public void displayCoordinate() {
        Console.WriteLine($"( {x}, {y})");
    }
}