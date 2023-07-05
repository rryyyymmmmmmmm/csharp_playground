public class Board 
{
    public const int SIZE = 4;
    public uint Size => SIZE;
    public List<int> ORGANIZED_ARRAY {get; set;} = new List<int>();
    public Tile[,] board_tiles {get; set;} = new Tile[SIZE,SIZE];
    
    private void boardGeneration(List<int> ORGANIZED_ARRAY) {

        var random = new Random();
        int i, j;
        int random_index;
        int random_number;

        for(i = 0; i < SIZE; i++) 
        {
            for (j = 0; j < SIZE; j++) 
            {
                random_index = (int)random.NextInt64(0, ORGANIZED_ARRAY.Count);
                (int, int) position = (i, j);
                random_number = ORGANIZED_ARRAY[random_index];
                ORGANIZED_ARRAY.RemoveAt(random_index);
                board_tiles[i,j] = new Tile(random_number, position);
            } 
        }
        /*i will access my tiles matrix normal, two loops
        with every iteration i'll generate a random number
        which will be an index to access ORGANIZED ARRAY.
        everytime i access a number from that array, i change its value to 0
        and f my loops, everytime i find 0, i regenerate a new random number
        ## horrible complexity, i'll find a new way to work it through

        i could eventually use a list as my ORGANIZED ARRAY, then everytime i access a value
        i delete la case t3ha, the size will change and thus i'll have -1 numbers in my
        random generator 
        
        */
    }
    private List<int> generateOrganizedArray(List<int> array)
    {
        int i;
        for(i = 0; i < SIZE*SIZE; i++) {
            array.Add(i+1);
        }
        i = SIZE*SIZE-1;
        array[i] = 0;
        return array;
    }


    public Board() 
    {
        ORGANIZED_ARRAY = generateOrganizedArray(ORGANIZED_ARRAY);
        boardGeneration(ORGANIZED_ARRAY);
    }
    
}