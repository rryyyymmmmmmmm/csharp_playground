
int cityHP=15, shipHP=10; //HP of both city and ship
int shipPos, shipPosGuess; //the position of the ship that will be initialized by the player later 
int turn=0; //number of turn, starts at 1 and increments by 1 automatically
int fireDamage=3, elecDamage=3, bothDamage=10, normalDamage=1;

//a function to check whether the position guessed was good or nah
    //will return 1 if position guessed was too high
    //-1 if too low
    //0 if guessed right

int PositionGuessed() {

    if(shipPos==shipPosGuess) {
        return 0;

    } else if(shipPos<shipPosGuess) {
        return 1;

    } else {
        return -1;
    }
}

//a turn counter, simple as that.

int Turn(bool message) {
    turn+=1;
    if(turn%3==0 && turn%5==0) {

        if(message==true) System.Console.Write("\tExpect canon to shoot");
        Color("blue");
        System.Console.Write(" Fire and Electricity");
        Color("green");
        System.Console.Write($" and cause 10 damage\n");
        return 15;

    } else if(turn%5==0) {
        if(message==true) System.Console.Write("\tExpect canon to shoot");
        Color("blue");
        System.Console.Write(" Electricity");
        Color("green");
        System.Console.Write($" and cause 3 damage\n");      
        return 5;

    } else if(turn%3==0) {
        if(message==true) System.Console.Write("\tExpect canon to shoot");
        Color("blue");
        System.Console.Write(" Fire");
        Color("green");
        System.Console.Write($" and cause 3 damage\n");           
        return 3;

    } else if(message==true) System.Console.Write("\tExpect canon to shoot");
        Color("green");
        System.Console.Write($" and cause 1 damage\n");
        return 1;

} 

//now, the function calculating the overral health of both the city and the ship

void Damage() { //P standing for parameter

    if(PositionGuessed()==0) {

        if(Turn(false)==15) {
           
            shipHP=shipHP-bothDamage;
            Color("blue");
            System.Console.WriteLine($"Manticore took {bothDamage} damage!");
       
        } else if(Turn(false)==5) {
           
            shipHP-=elecDamage;
            Color("blue");
            System.Console.WriteLine($"Manticore took {elecDamage} damage!");
       
        } else if(Turn(false)==3) {
            
            shipHP-=fireDamage;
            Color("blue");
            System.Console.WriteLine($"Manticore took {fireDamage} damage!");

        } else {
            
            shipHP-=normalDamage;
            Color("blue");        
            System.Console.WriteLine($"Manticore took {normalDamage} damage!");
        
        }
    
    }
    //the city takes one damage regardless
    cityHP-=normalDamage;
    Color("red");
    System.Console.WriteLine($"The City took {normalDamage} damage!");

    
}

//a function just to help me choose colors easier ig

void Color(string color) {
    switch (color) {
        case "red": Console.ForegroundColor=ConsoleColor.Red;
        break;
        case "blue": Console.ForegroundColor=ConsoleColor.Blue;
        break;
        case "yellow": Console.ForegroundColor=ConsoleColor.Yellow;
        break;
        case "green": Console.ForegroundColor=ConsoleColor.Green;
        break;
        case "white": Console.ForegroundColor=ConsoleColor.White;
        break;
    }
}

//the function for the main message showcasing

void Messages1() {

    Color("yellow");
    System.Console.Write($"\n- Round number {turn} | City's health : {cityHP}/15");
    System.Console.Write($" | Manticore's health : {shipHP}/10");
    Color("white");
    System.Console.Write("\n\n\tGuess the Manticore's position : ");
    
}

void Messages2() {

    if(PositionGuessed()==0) {
        Color("green");
        System.Console.Write("Right into the target! ");
    } else if(PositionGuessed()==-1) {
        Color("blue");
        System.Console.Write("Way too low. ");
    } else if(PositionGuessed()==1) {
        Color("blue");
        System.Console.Write("Way too high. ");

    }
}


//-----------------|-----------------|-----------------|-----------------|-----------------|-----------------|


//                                        | THE MAIN METHOD |



//-----------------|-----------------|-----------------|-----------------|-----------------|-----------------|
Console.Clear();
Color("red");
Console.Beep(261, 1000);
System.Console.Write("\n\tWelcome to the Boss Battle!");

do {
    Color("white");
    System.Console.Write("\nPlayer 1, enter Manticore's position (between 1 and 100): ");
    shipPos=Convert.ToInt32(Console.ReadLine());
} while(shipPos<0 || shipPos>100);

Color("green");
System.Console.WriteLine("Position chosen : " + shipPos);
Console.ReadKey(true);
Console.Clear();
while(true) {
    Turn(true);
    Messages1();
    shipPosGuess=Convert.ToInt32(Console.ReadLine());
    Messages2();
    Damage();
    if(shipHP<=0) {
        Color("green");
        System.Console.WriteLine("Manticore has been destroyed! You won!");   
        break;
    } else if(cityHP<=0) {
        Color("red");
        System.Console.WriteLine("The City has been destroyed...You lost!");
        break;
    } else if(cityHP<=0 && shipHP<=0) {
        Color("blue");
        System.Console.WriteLine("Both The City and Manticore have been destroyed... You kinda lost!");
        break;
    }
}
