namespace puzzle_15;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Board board = new Board();
        /*Console.WriteLine($"the organized array of length {board.ORGANIZED_ARRAY.Capacity}\n|");*/

        /*for(int i = 0; i < board.ORGANIZED_ARRAY.Count; i++) {
            Console.Write($"{board.ORGANIZED_ARRAY[i]} |");
        }*/

        Console.WriteLine("Generated tile : \n");
        
        for(int i = 0; i < board.Size; i++) {
            Console.Write("\n");
            for (int j = 0; j < board.Size; j++) {
                Console.Write($"{board.board_tiles[i, j].number}\t |");
            }
        }
        /*List<int> list = new List<int>();
        Console.WriteLine("give max size of list : ");
        int size = Int32.Parse(Console.ReadLine());
        for(int i = 0; i < size; i++) {
            list.Add(i+1);
        }
        foreach(int n in list) {
            Console.WriteLine(n);
        }
        Console.WriteLine($"size of list is {list.Count}");*/
    }
}
