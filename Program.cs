// -- MEMORY --

// Hunting the Manticore (Boss Battle challenge)

// Initial HP
int shipHealth = 10;
int cityHealth = 15;

// Config
int RANGE_MIN = 0;
int RANGE_MAX = 100;

int shipDistance = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore? ", RANGE_MIN, RANGE_MAX);

Console.Clear();
Console.WriteLine("Player 2, it is your turn.");
for (int round = 1; round <= 15; round++)
{
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {shipHealth}/10");
    int damage = GetCannonDamage(round);
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    int desiredRange = AskForNumberInRange("Enter desired cannon range: ", RANGE_MIN, RANGE_MAX);
    DamageManticore(desiredRange, damage);

    // End the game if the ship has been destroyed
    if (shipHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }
      
    // Damage the city, and end the gaem if the city's health is 0
    cityHealth -= 1;
    if (cityHealth <= 0)        
    {          
        Console.ForegroundColor = ConsoleColor.Red;          
        Console.WriteLine("The city of Consolas has been destroyed! The Uncoded One has won. It is a dark day...");
        Console.ForegroundColor = ConsoleColor.White;
        break;      
    }
}

void DamageManticore(int desiredRange, int damage)
{
    if (desiredRange < shipDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else if (desiredRange > shipDistance)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        shipHealth -= damage;
    }
}
int GetCannonDamage(int round)
{
    int damage = 1;
    bool thirdTurn = round % 3 == 0;
    bool fifthTurn = round % 5 == 0;
    if (thirdTurn && fifthTurn) // Damage from both gems
    {
        damage = 10;
    }
    else if (thirdTurn) // Every third turn of the crank, the fire gem activates
    {
        damage = 3;
    }
    else if (fifthTurn) // Every fifth turn of the crank, the electric gem activates
    {
        damage = 3;
    }
    return damage;
}

int AskForNumberInRange(string text, int min, int max)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < min || num > max)
    {
        Console.WriteLine($"Let's try again. Input a number between {min} and {max}.");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

// METHODS

// Countdown, using recursion

//int startingNum = AskForNumber(1);

//Countdown(startingNum);
//Console.Beep();
//Console.WriteLine("Countdown complete!");

//int AskForNumber(int min)
//{
//    Console.WriteLine($"Input a number above {min}.");
//    int num = Convert.ToInt32(Console.ReadLine());
//    while (num <= min)
//    {
//        Console.WriteLine($"Let's try again. Input a number above {min}.");
//        num = Convert.ToInt32(Console.ReadLine());
//    }
//    Console.Clear();
//    return num;
//}

//void Countdown(int num)
//{
//    Console.WriteLine(num);
//    if (num != 1) Countdown(num - 1); 
//}

// Taking a Number
// Text: number-related question for the user
//int AskForNumber(string text)
//{
//    Console.WriteLine(text);
//    return Convert.ToInt32(Console.ReadLine());
//}

//int AskForNumberInRange(string text, int min, int max)
//{
//    Console.WriteLine(text);
//    Console.WriteLine($"Input a number between {min} and {max}.");
//    int num = Convert.ToInt32(Console.ReadLine());
//    while (num < min || num > max)
//    {
//        Console.WriteLine($"Let's try again. Input a number between {min} and {max}.");
//        num = Convert.ToInt32(Console.ReadLine());
//    }
//    return num;
//}

//int result = AskForNumber("What is the distance between New York City and Boston?");
//int numberWithinRange = AskForNumberInRange("I really like the numbers between 5 and 12. Please input a number between them.", 5, 12);


// -- ARRAYS --

// The Laws of Freach
//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//int total = 0;
//foreach (int num in array)
//{
//    total += num;
//}
//float average = (float)total / array.Length;
//Console.WriteLine("Average value:" + average);


// The Replicator of D'To
//int len = 5;
//int[] array = new int[len];

//Console.WriteLine("Please input 5 numbers.");

//// Insert values into the array
//for (int i = 0; i < len; i++)
//{
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}

//// Move values into a 2nd array
//int[] array2 = new int[len];
//for (int i = 0; i < len; i++)
//{
//    array2[i] = array[i];
//}

//// Demonstrate that the arrays contain the same values
//Console.WriteLine($"{"Array 1", 21}   {"Array 2", 9}"); // Align the array names with the number output
//for (int i = 0; i < len; i++)
//{
//    Console.WriteLine($"Index {i + 1}: {array[i], 9} {array2[i], 11}");
//}

// -- LOOPS --

// The Magic Cannon
//for (int turn = 1; turn <= 100; turn++)
//{
//    string blastType = "Normal";
//    bool thirdTurn = turn % 3 == 0;
//    bool fifthTurn = turn % 5 == 0;
//    if (thirdTurn && fifthTurn) // Both gems activate
//    {
//        blastType = "Electric & Fire";
//        Console.ForegroundColor = ConsoleColor.Blue;
//    }
//    else if (thirdTurn) // Every third turn of the crank, the fire gem activates
//    {
//        blastType = "Fire";
//        Console.ForegroundColor = ConsoleColor.Red;
//    }
//    else if (fifthTurn) // Every fifth turn of the crank, the electric gem activates
//    {
//        blastType = "Electric";
//        Console.ForegroundColor = ConsoleColor.Yellow;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.White; // Reset text color for normal blasts
//    }
//    Console.WriteLine($"{turn}: {blastType}");
//}

// The Prototype (Pilot & Hunter coordinate on hitting a target)-
//int num = AskForNumberInRange("User 1, enter a number between 0 and 100: ", 0, 100);

//Console.Clear();
//Console.WriteLine("User 2, guess the number.");
//int guess = AskForNumber("What is your next guess? ");

//// Guide hunter to the number
//while (guess != num)
//{
//    if (guess < num)
//    {
//        Console.WriteLine(guess + " is too low.");
//    }
//    else
//    {
//        Console.WriteLine(guess + " is too high.");
//    }
//    guess = AskForNumber("What is your next guess? ");
//}

//Console.WriteLine("You guessed the number!");
//Console.Beep();

//int AskForNumber(string text)
//{
//    Console.Write(text);
//    return Convert.ToInt32(Console.ReadLine());
//}

//int AskForNumberInRange(string text, int min, int max)
//{
//    Console.Write(text);
//    int num = Convert.ToInt32(Console.ReadLine());
//    while (num < min || num > max)
//    {
//        Console.WriteLine($"Let's try again. Input a number between {min} and {max}.");
//        num = Convert.ToInt32(Console.ReadLine());
//    }
//    return num;
//}

// -- SWITCH --

//// Buying inventory
//Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\nWhat number do you want to see the price of? ");
//int item = Convert.ToInt32(Console.ReadLine());
//Console.Write("What is your name? ");
//float priceModifier = Console.ReadLine() == "Constantin" ? 0.5f : 1f; // Apply a discount for Constantin, who helped the shopkeeper by writing this program.
//string cost;

//cost = item switch
//{
//    1 => $"Rope costs {10 * priceModifier} gold.",
//    2 => $"Torches cost {15 * priceModifier} gold.",
//    3 => $"Climbing equipment costs {25 * priceModifier} gold.",
//    4 => $"Clean Water costs {1 * priceModifier} gold.",
//    5 => $"Machete costs {20 * priceModifier} gold.",
//    6 => $"Canoe costs {200 * priceModifier} gold.",
//    7 => $"Food supplies cost {1 * priceModifier} gold.",
//    _ => $"An invalid number was inputted ({item}). Please input a valid item number (1-7)."
//};

//Console.WriteLine(cost);

// -- IF STATEMENTS --

// Watchtower
//Console.Write("Input an x coordinate value. ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a y coordinate value. ");
//int y = Convert.ToInt32(Console.ReadLine());

//string dir1 = "";
//string dir2 = "";

//// Convert x input to direction
//if (x > 0)
//{
//    dir1 = "east";
//}
//else if (x < 0)
//{
//    dir1 = "west";
//}

//// Convert y input to direction
//if (y > 0)
//{
//    dir2 = "north";
//}
//else if (y < 0)
//{
//    dir2 = "south";
//}

//Console.WriteLine((dir1 == "" && dir2 == "") ? "The enemy is here!" : $"The enemy is to the {dir2 + dir1}!");


// Repairing the Clocktower
//Console.WriteLine("Please input a number for the clocktower.");
//int num = Convert.ToInt32(Console.ReadLine());
//bool isEven = num % 2 == 0;

//if (isEven) {
//    Console.WriteLine("Tick");
//}
//else {
//    Console.WriteLine("Tock");
//}

// Defense of Consolas

//Console.Title = "Defense of Consolas";

//Console.Write("Target Row? ");
//int row = Convert.ToInt32(Console.ReadLine());
//Console.Write("Target Column ");
//int column = Convert.ToInt32(Console.ReadLine());

// Format coordinates
//Console.WriteLine($"Desploy to:\n({row},{column - 1}) \n({row - 1},{column}) \n({row},{column + 1}) \n({row + 1},{column})");
//Console.Beep();

// -- MATH OPERATIONS --

//Dominion of Kings

//int POINTS_ESTATE = 1;
//int POINTS_DUCHY = 3;
//int POINTS_PROVINCE = 6;

//Console.WriteLine("Greetings, your majesty. Please input the number of estates in your domain.");
//int estates = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please input the number of duchies in your domain.");
//int duchies = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please input the number of provinces in your domain.");
//int provinces = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Your highness, your total score is: " + (estates * POINTS_ESTATE + duchies * POINTS_DUCHY + provinces * POINTS_PROVINCE));

//The Four Sisters and the Duckbear

//for (int day = 0; day < 10; day++)
//{
//    Console.WriteLine("Day " + (day + 1) + ". How many chocolate eggs were picked up today?");
//    int eggsNum = Convert.ToInt32(Console.ReadLine());
//    int duckbearEggs = eggsNum % 4;
//    int eggsPerSister = (eggsNum - duckbearEggs) / 4;
//    Console.WriteLine("Eggs for each sister: " + eggsPerSister + ". Eggs for duckbear: " + duckbearEggs);
//    Console.WriteLine(" ");

//}


/*
// The Triangle Farmer
float b;
float h;

b = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Input the triangle's height.");
h = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Triangle Area: " + Convert.ToString(b*h/2));


/*
Console.WriteLine("What kind of thing are we talking about?");
// The name of the object
string a = Console.ReadLine(); 
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
/*
 1. The description of the item
 2. Ominous suffix
 3. Item version
 */
/*
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " " + c + " " + d +  "!");
*/