Console.WriteLine("color:");
string color = Console.ReadLine();
Console.WriteLine("year:");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("brand:");
string brand = Console.ReadLine();
Console.WriteLine("model:");
string model = Console.ReadLine();
Console.WriteLine("fuelCapacity:");
double fuelCapacity = double.Parse(Console.ReadLine());
Console.WriteLine("fuelFor1Km:");
double fuelFor1Km = double.Parse(Console.ReadLine());
Console.WriteLine("currentFuel:");
double currentFuel = double.Parse(Console.ReadLine());

Vechile vechile1 = new Vechile(color, year, brand, model, fuelCapacity, fuelFor1Km, currentFuel);
vechile1.ShowInfo();
vechile1.Drive(100.0);