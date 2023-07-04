namespace catacombs_of_the_class;
class Program
{
   
    static void Main(string[] args)
    {
        string input;
        while(true) {
            Console.WriteLine("enter a password :");
            input = Console.ReadLine();
            if(input == "x") break;
            PasswordValidator.validator(input);
        }




        /*string input = "a";
        DoorState ds;
        Console.WriteLine("Creating a door... enter a passcode :");
        
        
        
        Door door = new Door(input);
        
        while(true) {
            Console.WriteLine($"Door is {door.door_state}\nWhat do you wish to do? :");
            input = Console.ReadLine();
            input = input.ToLower();

            switch (input) {
                case "open": ds = DoorState.Open; door.changeStateUnlocked(ds);
                break;
                case "close" : ds = DoorState.Closed; door.changeStateUnlocked(ds);
                break;
                case "lock" : ds = DoorState.Locked; 
                break;
                case "unlock" : //requesting passcode 
                break;
                case "exit": Environment.Exit(0);
                break;
                default: Console.WriteLine("Error, operations are either open, close, lock or unlock"); 
                break;
            }

            
        }*/
        /*Point a = new Point(2, 3);
        Point b = new Point(-4, 0);

        a.displayCoordinate();
        b.displayCoordinate();

        Color c = new Color();
        Color d = new Color();

        c.setColor(200, 56, 96);
        d = Color.Green();

        c.displayColor();
        d.displayColor();*/

        //Card.createAllCards();
        
    }
}
