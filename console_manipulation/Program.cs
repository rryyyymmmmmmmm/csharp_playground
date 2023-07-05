namespace console_manipulation;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        while(true) {
            Console.Write(Console.GetCursorPosition().Left);
            Console.Write(", ");
            Console.Write(Console.GetCursorPosition().Top);
            Console.WriteLine("");
            Thread.Sleep(500);
        }
    }
}
