// Buying inventory


Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\nWhat number do you want to see the price of? ");
int item = Convert.ToInt32(Console.ReadLine());
Console.Write("What is your name? ");
float priceModifier = Console.ReadLine() == "Constantin" ? 2f : 1f; // Apply a discount for Constantin, who helped the shopkeeper by writing this program.
string cost;

cost = item switch
{
    1 => $"Rope costs {10 / priceModifier} gold.",
    2 => $"Torches cost {15 / priceModifier} gold.",
    3 => $"Climbing equipment costs {25 / priceModifier} gold.",
    4 => $"Clean Water costs {1 / priceModifier} gold.",
    5 => $"Machete costs {20 / priceModifier} gold.",
    6 => $"Canoe costs {200 / priceModifier} gold.",
    7 => $"Food supplies cost {1 / priceModifier} gold.",
    _ => $"An invalid number was inputted ({item}). Please input a valid item number (1-7)."
};

Console.WriteLine(cost);


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