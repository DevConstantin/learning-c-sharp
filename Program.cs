// Polymorphism


// Inheritance & Polymorphism

// -- The Old Robot --

Console.WriteLine("Commands: on / off / north / south / west / east");
Robot robot = new();

for (int i = 0; i < 3; i++)
{
    string choice = Console.ReadLine();
    RobotCommand command = choice switch
    {
        "on" => new OnCommand(),
        "off" => new OffComand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "west" => new WestCommand(),
        "east" => new EastCommand(),
    };

    robot.Commands[i] = command;
}

Console.WriteLine();
robot.Run();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }

    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot) {
        if (!robot.IsPowered) return;
        robot.Y += 1; 
    }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot) {
        if (!robot.IsPowered) return;
        robot.Y -= 1; 
    }
}

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot) {
        if (!robot.IsPowered) return;
        robot.X -= 1; 
    }
}

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot) {
        if (!robot.IsPowered) return;
        robot.X += 1; 
    }
}

public class OnCommand : RobotCommand { public override void Run(Robot robot) { robot.IsPowered = true; } }
public class OffComand : RobotCommand { public override void Run(Robot robot) {robot.IsPowered = false; } }
public abstract class RobotCommand { public abstract void Run(Robot robot); }

// -- Pack -- 
//Arrow arrow = new();
//Console.WriteLine("Arrow damage:" + arrow.GetDamage());

//Console.WriteLine(new Bow().ToString());

//Pack pack = new(4, 7, 6);

//while (true)
//{
//    Console.WriteLine(pack.ToString());
//    Console.WriteLine($"Choose an item to add to your pack: \n1. Arrow\n2. Bow\n3. Rope\n4. Water\n5. Food\n6. Sword");

//    ConsoleKey key = GetKey();
//    InventoryItem item = key switch
//    {
//        ConsoleKey.D1 => new Arrow(),
//        ConsoleKey.D2 => new Bow(),
//        ConsoleKey.D3 => new Rope(),
//        ConsoleKey.D4 => new Water(),
//        ConsoleKey.D5 => new Food(),
//        ConsoleKey.D6 => new Sword(),
//    };

//    bool success = pack.Add(item);
//    if (!success)
//    {
//        Console.Clear();
//        Console.Beep();
//        Console.WriteLine($"\nFailed to add {item}!");
//    }

//    Console.WriteLine("\n");
//}

//ConsoleKey GetKey()
//{
//    while (true)
//    {
//        ConsoleKey key = Console.ReadKey().Key;
//        if (key == ConsoleKey.D1 || key == ConsoleKey.D2 || key == ConsoleKey.D3 || key == ConsoleKey.D4 || key == ConsoleKey.D5 || key == ConsoleKey.D6) return key;
//    }
//}

//public class Pack
//{
//    public byte MaxItems { get; init; }
//    public float MaxWeight { get; init; }
//    public float MaxVolume { get; init; }

//    public int ItemCount { get; private set; } = 0;
//    public float Weight { get; private set; } = 0f;
//    public float Volume { get; private set; } = 0f;

//    public InventoryItem[] InventoryItems { get; init; }

//    public new string ToString()
//    {
//        if (InventoryItems.Length == 0) return "The pack is empty.";

//        string packContents = "Pack containing ";
//        foreach (InventoryItem inventoryItem in InventoryItems)
//        {
//            if (inventoryItem != null) packContents += " " + inventoryItem.ToString();
//        }
//        return packContents == "Pack containing " ? "The pack is empty." : packContents; // Check if the packContests string is the same, and indicate that it's empty if it is
//    }

//    public Pack(byte maxItems, float maxWeight, float maxVolume)
//    {
//        MaxItems = maxItems;
//        MaxWeight = maxWeight;
//        MaxVolume = maxVolume;
//        InventoryItems = new InventoryItem[maxItems];
//    }

//    private bool CapacityReached() => ItemCount >= MaxItems;
//    private bool ExceedsWeight(float itemWeight) => (Weight + itemWeight) > MaxWeight;
//    private bool ExceedsVolume(float itemVolume) => (Volume + itemVolume) > MaxVolume;

//    public bool Add(InventoryItem item)
//    {
//        if (CapacityReached() || ExceedsWeight(item.Weight) || ExceedsVolume(item.Volume)) return false;

//        InventoryItems[ItemCount] = item;
//        ItemCount++;
//        Weight += item.Weight;
//        Volume += item.Volume;

//        return true;
//    }
//}

//public class InventoryItem
//{
//    public float Weight { get; init; }
//    public float Volume { get; init; }

//    public InventoryItem(float weight, float volume)
//    {
//        Weight = weight;
//        Volume = volume;
//    }
//}

//public class Arrow() : InventoryItem(0.1f, 0.05f)
//{
//    private readonly float BaseDamage = 10f;
//    public float GetDamage()
//    {
//        return BaseDamage * this.Weight;
//    }
//}


//public class Bow() : InventoryItem(1f, 4f)
//{
//    public new string ToString() => "Bow";
//}

//public class Rope() : InventoryItem(1f, 1.5f)
//{
//    public new string ToString() => "Rope";
//}

//public class Water() : InventoryItem(2f, 4f)
//{
//    public new string ToString() => "Water";
//}

//public class Food() : InventoryItem(1f, 0.5f)
//{
//    public new string ToString() => "Food";
//}

//public class Sword() : InventoryItem(5f, 3f)
//{
//    public new string ToString() => "Sword";
//}


// --The Catacombs of the Class--

// The Password Validator

//while (true)
//{
//    string password = RequestPassword();
//    PasswordValidator Validator = new(password);
//    Console.WriteLine(Validator.ValidPassword() ? "Valid\n" : "Invalid\n");
//}

//string RequestPassword()
//{
//    Console.Write("Input password: ");
//    string password = Console.ReadLine();
//    return password;
//}

//public class PasswordValidator
//{
//    public string Password { get; }
//    public byte LENGTH_MIN { get; } = 6;
//    public byte LENGTH_MAX { get; } = 13;

//    public PasswordValidator(string password)
//    {
//        Password = password;
//    }

//    public bool ValidPassword() => ValidLength() & HasUppercase() & HasLowercase() & HasNumber() & !InvalidChars();

//    public bool ValidLength()
//    {
//        byte length = 0;
//        foreach (char letter in Password)
//        {
//            length += 1;
//        }
//        return (length >= LENGTH_MIN && length <= LENGTH_MAX);
//    }

//    public bool HasUppercase()
//    {
//        foreach (char letter in Password)
//        {
//            if (char.IsUpper(letter)) return true;
//        }
//        return false;
//    }

//    public bool HasLowercase()
//    {
//        foreach (char letter in Password)
//        {
//            if (char.IsLower(letter)) return true;
//        }
//        return false;
//    }

//    public bool HasNumber()
//    {
//        foreach (char letter in Password)
//        {
//            if (char.IsDigit(letter)) return true;
//        }
//        return false;
//    }

//    public bool InvalidChars()
//    {
//        foreach (char letter in Password)
//        {
//            if (letter == 'T' | letter == '&') return true;
//        }
//        return false;
//    }
//}


// Rock, Paper, Scissors game

//Console.WriteLine("Rock, Paper, Scissors!");
//while (true)
//{
//    GameItem player1Item = GetPlayerChoice(1);
//    GameItem player2Item = GetPlayerChoice(2);
//    ShowWinner(player1Item, player2Item);
//    Console.WriteLine();
//}


//GameItem GetPlayerChoice(byte playerNum)
//{
//    Console.Write($"Player {playerNum} choose item (rock / paper / scissors) ");
//    return Console.ReadLine() switch
//    {
//        "rock" => new GameItem(Item.Rock),
//        "paper" => new GameItem(Item.Paper),
//        "scissors" => new GameItem(Item.Scissors),
//        _ => new GameItem(Item.Rock),
//    };
//}

//void ShowWinner(GameItem item1, GameItem item2)
//{
//    if (item1.Item == item2.Item)
//    {
//        Console.WriteLine("It's a draw.");
//    }
//    else if (item1.CanBeat == item2.Item) 
//    {
//        Console.WriteLine("Player 1 has won.");
//    }
//    else
//    {
//        Console.WriteLine("Player 2 has won.");
//    }
//}

//public class GameItem
//{
//    public Item Item { get; private set; }

//    public GameItem(Item item)
//    {
//        Item = item;
//    }

//    public Item CanBeat => Item == Item.Scissors ? Item.Paper : Item == Item.Rock ? Item.Scissors : Item.Rock;
//}

//public enum Item { Rock, Paper, Scissors }

// The Locked Door

//short passcode = 1234;
//Door door = new(State.Closed, passcode); // The worst possible password?

//Console.WriteLine($"The Locked Door. Default password: {passcode}.\n");
//while (true)
//{
//    Console.WriteLine($"The door is currently: {door.State}.\nWhat do you want to do with the door?\n1. Open\n2. Close\n3. Lock\n4. Unlock\n5. Set new passcode.");
//    ManageDoor();
//}

//void ManageDoor()
//{
//    int choice = Convert.ToByte(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            {
//                door.Open();
//                break;
//            }
//        case 2:
//            {
//                door.Close();
//                break;
//            }
//        case 3:
//            {
//                door.Lock();
//                break;
//            }
//        case 4:
//            {
//                door.Unlock();
//                break;
//            }
//        case 5:
//            {
//                Console.Write("Input passcode: ");
//                short currentPasscode = Convert.ToInt16(Console.ReadLine());
//                door.SetPasscode(currentPasscode);
//                break;
//            }
//        default:
//            {
//                door.Open();
//                break;
//            }
//    }
//    Console.WriteLine(); // Add a space between each interaction
//}

//public class Door
//{
//    public State State { get; private set; }
//    private short Passcode;

//    public Door (State state, short passcode)
//    {
//        State = state;
//        Passcode = passcode;
//    }

//    public void SetPasscode(short currentCode)
//    {
//        if (Passcode == currentCode)
//        {
//            Console.Write("Input new passcode: ");      // User is only prompted to set a new password if they input the correct passcode
//            short newPasscode = Convert.ToInt16(Console.ReadLine()); 
//            Passcode = newPasscode;
//        }
//        else
//        {
//            Console.WriteLine("Wrong passcode! Passcode will not be updated.");
//        }
//    }

//    public void Open()
//    {
//        switch (State) {
//            case State.Open:
//                Console.WriteLine("The door is already open.");
//                break;
//            case State.Locked:
//                Console.WriteLine("The door is locked and cannot be opened.");
//                break;
//            case State.Closed:
//                State = State.Open;
//                Console.WriteLine("The door has been opened.");
//                break;
//        }
//    }

//    public void Close()
//    {
//        switch (State)
//        {
//            case State.Closed:
//                Console.WriteLine("The door is already closed!");
//                break;
//            case State.Locked:
//                Console.WriteLine("The door is locked, and already closed.");
//                break;
//            case State.Open:
//                State = State.Closed;
//                Console.WriteLine("The door has been closed.");
//                break;

//        }
//    }

//    public void Lock()
//    {
//        if (State == State.Closed)
//        {
//            Console.WriteLine("The door is locked.");
//            State = State.Locked;
//        }
//        else
//        {
//            Console.WriteLine($"The door is {State} and cannot be locked.");
//        }
//    }

//    public void Unlock()
//    {
//        if (State != State.Locked)
//        {
//            Console.WriteLine("The door is not currently locked!");
//            return;
//        }

//        Console.Write("Input passcode: ");
//        short passcode = Convert.ToInt16(Console.ReadLine());
//        if (Passcode == passcode)
//        {
//            State = State.Closed;
//            Console.WriteLine("Door unlocked.");
//        }
//        else
//        {
//            Console.WriteLine("Incorrect passcode.");
//        }
//    }
//}

//public enum State { Open, Closed, Locked }


// The Card

//Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow };
//Rank[] ranks = { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

//Card card = new(Color.Red, Rank.One);
//Console.WriteLine(card.IsNumberCard());
//Console.WriteLine();

//CreateDeck();

//void CreateDeck()
//{
//    foreach (Color color in colors) 
//    {
//        foreach (Rank rank in ranks)
//        {
//            Card card = new Card(color, rank);
//            Console.WriteLine($"The {color} {rank}");
//        }
//        Console.WriteLine();
//    }
//}

//public class Card
//{
//    public Color Color { get; };
//    public Rank Rank { get; };

//    public Card(Color color, Rank rank)
//    {
//        Color = color;
//        Rank = rank;
//    }

//    public bool IsNumberCard()
//    {
//        return Rank switch
//        {
//            Rank.DollarSign => false,
//            Rank.Percent => false,
//            Rank.Caret => false,
//            Rank.Ampersand => false,
//            _ => true,
//        };
//    }

//    public bool IsSymbolCard()
//    {
//        return !IsNumberCard();
//    }
//}

//public enum Color { Red, Green, Blue, Yellow}
//public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }


// The Color
//Color customColor = new();
//Color commonColor = Color.Red;

//Console.WriteLine($"Fixed Color: R({customColor.R}) G({customColor.G}) B({customColor.B})");
//Console.WriteLine($"Common Color: R({commonColor.R}) G({commonColor.G}) B({commonColor.B})");


//public class Color
//{
//    public int R { get; init; }
//    public int G { get; init; }
//    public int B { get; init; }

//    // Black by default
//    public Color()
//    {
//        R = 0;
//        G = 0;
//        B = 0;
//    }

//    public Color(int r, int g, int b)
//    {
//        R = r;
//        G = g;
//        B = b;
//    }

//    // Static methods for retreiving colors
//    public static Color White { get; } = new Color(255, 255, 255);
//    public static Color Black { get; } = new Color(0, 0, 0);
//    public static Color Red { get; } = new Color(255, 0, 0);
//    public static Color Orange { get; } = new Color(255, 165, 0);
//    public static Color Yellow { get; } = new Color(255, 255, 0);
//    public static Color Green { get; } = new Color(0, 128, 0);
//    public static Color Blue { get; } = new Color(0, 0, 255);
//    public static Color Purple { get; } = new Color(128, 0, 128);
//}

// The point
//Point point1 = new(2, 3);
//Point point2 = new(-4, 0);
//Console.WriteLine(point1.GetPoint());
//Console.WriteLine(point2.GetPoint());

//public class Point
//{
//    public float X { get; init; }
//    public float Y { get; init; }

//    public Point()
//    {
//        X = 0;
//        Y = 0;
//    }

//    public Point(float x, float y)
//    {
//        X = x;
//        Y = y;
//    }

//    public string GetPoint()
//    {
//        return $"({X},{Y})";
//    }
//}


// -- CLASSES --

// Vin Fletcher's Arrows
//Arrow myArrow = null;
//Arrowhead arrowhead = Arrowhead.steel;
//float desiredLength;
//Fletching fletching = Fletching.gooseFeathers;

//// Let user choose an arrow type. 3 Presets, 1 custom

//Console.WriteLine("Which arrow type are you looking to purchase? (1-4):\n1. Elite Arrow\n2. Beginner Arrow\n3. Marksman Arrow\n4. Custom");
//int desiredArrow = Convert.ToInt32(Console.ReadLine());
//Console.Clear();
//switch (desiredArrow)
//{
//    case 1:
//        myArrow = Arrow.CreateEliteArrow();
//        break;
//    case 2:
//        myArrow = Arrow.CreateBeginnerArrow();
//        break;
//    case 3:
//        myArrow = Arrow.CreateMarksmanArrow();
//        break;

//    // Custom arrow functionality
//    case 4:
//        Console.WriteLine("Choose arrowhhead type (1-3):\n1. Steel\n2. Wood\n3. Obsidian");
//        int desiredArrowhead = Convert.ToInt32(Console.ReadLine());
//        desiredLength = AskForNumberInRange("\nChoose desired length in cm: (60-100) ", 60, 100);
//        Console.WriteLine("\nChoose fletching type (1-3):\n1. Plastic\n2. Turkey Feathers\n3. Goose Feathers");
//        int desiredFletching = Convert.ToInt32(Console.ReadLine());

//        // Convert user selection to enums
//        switch (desiredArrowhead)
//        {
//            case 1:
//                arrowhead = Arrowhead.steel;
//                break;
//            case 2:
//                arrowhead = Arrowhead.wood;
//                break;
//            case 3:
//                arrowhead = Arrowhead.obsidian;
//                break;
//            default:
//                arrowhead = Arrowhead.wood;
//                break;
//        }

//        switch (desiredFletching)
//        {
//            case 1:
//                fletching = Fletching.plastic;
//                break;
//            case 2:
//                fletching = Fletching.turkeyFeathers;
//                break;
//            case 3:
//                fletching = Fletching.gooseFeathers;
//                break;
//            default:
//                fletching = Fletching.gooseFeathers;
//                break;
//        }

//        myArrow = new(arrowhead, desiredLength, fletching);   
//        break;

//    default:
//        myArrow = Arrow.CreateBeginnerArrow();
//        break;
//}

//Console.WriteLine($"Final arrow cost: {myArrow?.GetCost()}\n");

//Arrow standardArrow = new();
//Console.WriteLine("Standard arrow cost: " + standardArrow.GetCost());
//standardArrow._fletching = Fletching.gooseFeathers; // test setter function
//Console.WriteLine("Standard arrow (goose feathers) cost: " + standardArrow.GetCost());

//int AskForNumberInRange(string text, int min, int max)
//{
//    Console.Write(text);
//    int num = Convert.ToInt32(Console.ReadLine());
//    while (num <= min || num >= max)
//    {
//        Console.WriteLine($"Let's try again. Input a number between {min} and {max}.");
//        num = Convert.ToInt32(Console.ReadLine());
//    }
//    return num;
//}

//class Arrow
//{
//    public Arrowhead _arrowhead { get; set; }
//    public float _length { get; init; }
//    public Fletching _fletching { get; set; }

//    // constructors
//    public Arrow()
//    {
//        _arrowhead = Arrowhead.wood;
//        _length = 75f;
//        _fletching = Fletching.gooseFeathers;
//    }

//    public Arrow(Arrowhead arrowhead, float length, Fletching fletching)
//    {
//        _arrowhead = arrowhead;
//        _length = length;
//        _fletching = fletching;
//    }

//    // methods

//    // static methods for arrow presets
//    public static Arrow CreateEliteArrow() => new(Arrowhead.steel, 95f, Fletching.plastic);
//    public static Arrow CreateBeginnerArrow() => new(Arrowhead.wood, 75f, Fletching.gooseFeathers);
//    public static Arrow CreateMarksmanArrow() => new(Arrowhead.steel, 65f, Fletching.gooseFeathers);

//    public float GetCost()
//    {
//        float arrowheadCost = 0;
//        float lengthCost = (float)0.05 * _length; // Length cost is calculated right away, since it's straight forward
//        float fletchingCost = 0;

//        Console.WriteLine(_arrowhead + " " + _length + " " + _fletching);

//        // Calculate cost of arrowhead
//        if (_arrowhead == Arrowhead.steel)
//        {
//            arrowheadCost = 10;
//        }
//        else if (_arrowhead == Arrowhead.wood)
//        {
//            arrowheadCost = 3;
//        }
//        else if (_arrowhead == Arrowhead.obsidian)
//        {
//            arrowheadCost = 5;
//        }

//        // Calculate cost of fletching
//        if (_fletching == Fletching.plastic)
//        {
//            fletchingCost = 10;
//        }
//        else if (_fletching == Fletching.turkeyFeathers)
//        {
//            fletchingCost = 5;
//        }
//        else if (_fletching == Fletching.gooseFeathers)
//        {
//            fletchingCost = 3;
//        }

//        return arrowheadCost + lengthCost + fletchingCost;
//    }
//}

//enum Arrowhead { steel, wood, obsidian }
//enum Fletching { plastic, turkeyFeathers, gooseFeathers }

// -- Tuples --
//(SoupType type, Ingredient ingredient, Seasoning seasoning) soup = (SoupType.soup, Ingredient.potatoes, Seasoning.salty);

//Console.WriteLine(" -HEARTY SOUPS-");

//Console.WriteLine("Choose a type (1-3): \n1. Soup\n2. Stew\n3. Gumbo ");
//int desiredType = Convert.ToInt32(Console.ReadLine());
//switch (desiredType)
//{
//    case 1:
//        soup.type = SoupType.soup;
//        break;
//    case 2:
//        soup.type = SoupType.stew;
//        break;
//    case 3:
//        soup.type = SoupType.gumbo;
//        break;
//}

//Console.Clear();
//Console.WriteLine("Choose an ingredient (1-4): \n1. Mushrooms\n2. Chicken\n3. Carrots\n4. Potatoes ");
//int desiredIngredient = Convert.ToInt32(Console.ReadLine());
//switch (desiredIngredient) 
//{
//    case 1: 
//        soup.ingredient = Ingredient.mushrooms;    
//        break;
//    case 2:
//        soup.ingredient = Ingredient.chicken;
//        break;
//    case 3:
//        soup.ingredient = Ingredient.carrots;
//        break;
//    case 4:
//        soup.ingredient = Ingredient.potatoes;
//        break;
//}

//Console.Clear();
//Console.WriteLine("Choose a seasoning (1-3): \n1. Spicy\n2. Salty\n3. Sweet");
//int desiredSeasoning = Convert.ToInt32(Console.ReadLine());
//switch (desiredSeasoning)
//{
//    case 1:
//        soup.seasoning = Seasoning.spicy;
//        break;
//    case 2:
//        soup.seasoning = Seasoning.salty;
//        break;
//    case 3:
//        soup.seasoning = Seasoning.sweet;
//        break;
//}

//Console.Beep();
//Console.WriteLine($"\n{soup.type} {soup.ingredient} {soup.seasoning}");

//enum SoupType { soup, stew, gumbo }
//enum Ingredient { mushrooms, chicken, carrots, potatoes }
//enum Seasoning { spicy, salty, sweet }

// -- Enum -- 
// Simula's Test

//ChestState current = ChestState.Locked;

//while (true) {
//    WriteMessage();
//    string desiredAction = Console.ReadLine();
//    AdvanceState(desiredAction);
//}

//// Format a message for the user based on the current chest state
//void WriteMessage()
//{
//    string stateStr;
//    if (current == ChestState.Open)
//    {
//        stateStr = "open";
//    }
//    else if (current == ChestState.Closed)
//    {
//        stateStr = "unlocked";
//    }
//    else
//    {
//        stateStr = "locked";
//    }
//    Console.Write($"The chest is {stateStr}. What do you want to do? ");
//}

//// Advance the chest to its next stage, depending on inputted desired action
//void AdvanceState(string desiredAction)
//{   
//    if ((current == ChestState.Open && desiredAction == "close") || (current == ChestState.Locked && desiredAction == "unlock"))
//    {
//        current = ChestState.Closed;
//    }
//    else if (current == ChestState.Closed && desiredAction == "lock")
//    {
//        current = ChestState.Locked;
//    }
//    else if (current == ChestState.Closed && desiredAction == "open")
//    {
//        current = ChestState.Open;
//    }
//    else
//    {
//        Console.WriteLine("Invalid action.");
//    }
//}

//enum ChestState { Open, Closed, Locked };



// -- MEMORY --

// Hunting the Manticore (Boss Battle challenge)

// Initial HP
//int shipHealth = 10;
//int cityHealth = 15;

//// Config
//int RANGE_MIN = 0;
//int RANGE_MAX = 100;

//int shipDistance = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore? ", RANGE_MIN, RANGE_MAX);

//Console.Clear();
//Console.WriteLine("Player 2, it is your turn.");
//for (int round = 1; round < 15; round++)
//{
//    Console.WriteLine("-----------------------------------------------------");
//    Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {shipHealth}/10");
//    int damage = GetCannonDamage(round);
//    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
//    int desiredRange = AskForNumberInRange("Enter desired cannon range: ", RANGE_MIN, RANGE_MAX);
//    DamageManticore(desiredRange, damage);

//    // End the game if the ship has been destroyed
//    if (shipHealth <= 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Blue;
//        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
//        Console.ForegroundColor = ConsoleColor.White;
//        break;
//    }

//    // Damage the city, and end the gaem if the city's health is 0
//    cityHealth -= 1;
//    if (cityHealth <= 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("The city of Consolas has been destroyed! The Uncoded One has won. It is a dark day...");
//        Console.ForegroundColor = ConsoleColor.White;
//        break;
//    }
//}

//void DamageManticore(int desiredRange, int damage)
//{
//    if (desiredRange < shipDistance)
//    {
//        Console.WriteLine("That round FELL SHORT of the target.");
//    }
//    else if (desiredRange > shipDistance)
//    {
//        Console.WriteLine("That round OVERSHOT the target.");
//    }
//    else
//    {
//        Console.WriteLine("That round was a DIRECT HIT!");
//        shipHealth -= damage;
//    }
//}
//int GetCannonDamage(int round)
//{
//    int damage = 1;
//    bool thirdTurn = round % 3 == 0;
//    bool fifthTurn = round % 5 == 0;
//    if (thirdTurn && fifthTurn) // Damage from both gems
//    {
//        damage = 10;
//    }
//    else if (thirdTurn) // Every third turn of the crank, the fire gem activates
//    {
//        damage = 3;
//    }
//    else if (fifthTurn) // Every fifth turn of the crank, the electric gem activates
//    {
//        damage = 3;
//    }
//    return damage;
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