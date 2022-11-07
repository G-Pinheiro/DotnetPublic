using CargoShipLoader;

//Console Version of Cargo Ship

// initialize Ship class
Ship myCargoShip = new Ship();

string WelcomeMessage = "Welcome to Cargo Ship. The goal of this game is to load the ship to its maximum capacity \n" +
    "by adding motor cycles, cars, trucks and train cars. \n" +
    "A cycle takes 3 units of weight. \n" +
    "A car takes 5 units. \n" +
    "A truck takes 11 units. \n" +
    "A train car takes 17 units. \n" +
    "";

Console.WriteLine(WelcomeMessage);

while (myCargoShip.Capacity !=  myCargoShip.getShipLoad())
{
    Console.WriteLine("The ship capacity is " + myCargoShip.Capacity + "\n" +
        "The ship has " + myCargoShip.CycleCount + " motorcycles on board;\n" +
        "The ship has " + myCargoShip.CarCount + " cars on board;\n" +
        "The ship has " + myCargoShip.TruckCount + " trucks on board;\n" +
        "The ship has " + myCargoShip.TrainCarCount + " train cars on board.\n" +
        "The ship currently has " + myCargoShip.getShipLoad() + "total units.\n" +
        "");

    // Used to capture user input and assign to each property of the ship class
    int x;

    Console.WriteLine("How many motor cycles would you like to put on the ship? ");
    x = int.Parse(Console.ReadLine());
    myCargoShip.CycleCount = x;
    Console.WriteLine("\n" +
        "Current ship load: " + myCargoShip.getShipLoad() + " Remaining: " + myCargoShip.overUnder());

    Console.WriteLine("How many cars would you like to put on the ship? ");
    x = int.Parse(Console.ReadLine());
    myCargoShip.CarCount = x;
    Console.WriteLine("\n" +
        "Current ship load: " + myCargoShip.getShipLoad() + " Remaining: " + myCargoShip.overUnder());

    Console.WriteLine("How many trucks would you like to put on the ship? ");
    x = int.Parse(Console.ReadLine());
    myCargoShip.TruckCount = x;
    Console.WriteLine("\n" +
        "Current ship load: " + myCargoShip.getShipLoad() + " Remaining: " + myCargoShip.overUnder());

    Console.WriteLine("How many train cars would you like to put on the ship? ");
    x = int.Parse(Console.ReadLine());
    myCargoShip.TrainCarCount = x;
    Console.WriteLine("\n" +
        "Current ship load: " + myCargoShip.getShipLoad() + " Remaining: " + myCargoShip.overUnder());

    Console.WriteLine("The ship now has " + myCargoShip.getShipLoad() + " total units of weight on board.\n" +
        "");

}

Console.WriteLine("You loaded the ship sucessfully! ");
Console.ReadLine();