ConsoleKeyInfo Key;
int arrowHeadInt, arrowFletching, orderType, preDefArrowType;
float arrowShaft;
Arrow arrow;


do {
    
    System.Console.WriteLine("Hello and welcome to the arrows shop! Here are the arrows we have available and their price : ");
    System.Console.WriteLine("\nArrow Heads : \n1- Steel : 10 gold\n2- Wood : 3 gold \n3- Obsidian : 5 gold");
    System.Console.WriteLine("\nArrow Shafts : Starting at 60cm with " + 0.05*60 + " gold for 60cm up to 100cm, 0.05 gold for each cm added");
    System.Console.WriteLine("\nArrow Fletching : \n1- Plastic : 10 gold\n2- Turkey Feathers : 5 gold \n3- Goose Feathers : 3 gold");
    Console.WriteLine("\nPre-defined arrows are : \n1- The Elite Arrow, made from a steel arrowhead, plastic fletching, and a 95 cm shaft.\n2- The Beginner Arrow, made from a wood arrowhead, goose feathers, and a 75 cm shaft\n3- The Marksman Arrow, made from a steel arrowhead, goose feathers, and a 65 cm shaft.");

    do {
    Console.WriteLine("Would you like to order a custom arrow or a pre-defined one? (1 for custom, 2 for pre-defined) :");
    orderType = Convert.ToInt32(Console.ReadLine());
    } while(orderType < 1 || orderType > 2);

    if (orderType == 1) {
        do {
        System.Console.WriteLine("What type of arrow head would you like (1, 2 or 3) ? : ");
        arrowHeadInt = Convert.ToInt32(Console.ReadLine());
        } while(arrowHeadInt<1 || arrowHeadInt>3);

        do{
        System.Console.WriteLine("How long an arrow shaft would you like (between 60 to 100cm) ? : ");
        arrowShaft = Convert.ToInt32(Console.ReadLine());
        } while(arrowShaft<60 || arrowShaft>100);

        do{
        System.Console.WriteLine("What type of arrow fletching would you like (1, 2 or 3) ? : ");
        arrowFletching = Convert.ToInt32(Console.ReadLine());
        } while(arrowFletching<1 || arrowFletching>3);

    } else {
        do {
        System.Console.WriteLine("What type of pre-defined arrow would you like (1, 2 or 3) ? : ");
        preDefArrowType = Convert.ToInt32(Console.ReadLine());
        } while(preDefArrowType<1 || preDefArrowType>3);

        switch (preDefArrowType) {
            case 1:
             //Elite
                arrow = new ArrowElite();
                arrowHeadInt = (int)ArrowHead.Steel;
                arrowShaft = 95;
                arrowShaft = (int)Fletching.Plastic;
            break;
            case 2: //Beginner
                arrowHeadInt = (int)ArrowHead.Wood;
                arrowShaft = 75;
                arrowShaft = (int)Fletching.GooseFeather;
            break;
            case 3: //Marksman
                arrowHeadInt = (int)ArrowHead.Steel;
                arrowShaft = 65;
                arrowShaft = (int)Fletching.GooseFeather;
            break;
        }
    }
    
    Arrow arrow = new Arrow {_ArrowHead = (ArrowHead)arrowHeadInt, _Shaft = arrowShaft, _Fletching = (Fletching)arrowFletching};

    System.Console.WriteLine($"Alright then! Crafting you a beautiful {arrow._Shaft} cm long, {arrow._ArrowHead} headed and {arrow._Fletching} fletching arrow!");
    System.Console.WriteLine("The price will be " + arrow.getCost() + " gold.");
    System.Console.WriteLine("Press SPACEBAR when you're finished for today.");

    Key = Console.ReadKey(false);
    Console.Clear();

} while(Key.Key!=ConsoleKey.Spacebar);
Environment.Exit(0);
    
class Arrow {

    //private ArrowHead arrowHead;
    public ArrowHead _ArrowHead {get; init;}
    //private float shaft;
    public float _Shaft {get; init;}
    //private Fletching fletching;
    public Fletching _Fletching {get; init;}

    static 
    /*public Arrow(ArrowHead arrowHead, float shaft, Fletching fletching) {
        this.arrowHead = arrowHead;
        this.shaft = shaft;
        this.fletching = fletching;
    }*/

    public float getCost() {
        float cost=0;
        switch (_ArrowHead) {
            case ArrowHead.Steel : cost+=10;
            break;
            case ArrowHead.Obsidian : cost+=5;
            break;
            case ArrowHead.Wood : cost+=3;
            break;
        }
        //_Arrow.shaft condition {
            cost=cost+_Shaft*0.05f;
        //}

        switch (_Fletching) {
            case Fletching.Plastic : cost+=10;
            break;
            case Fletching.TurkeyFeather : cost+=5;
            break;
            case Fletching.GooseFeather : cost+=3;
            break;
        }
        return cost;
    }
}
enum ArrowHead{Steel=1, Wood=2, Obsidian=3};
enum Fletching{Plastic=1, TurkeyFeather=2, GooseFeather=3};