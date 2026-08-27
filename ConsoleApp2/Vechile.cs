using System.Drawing;

class Vechile
{
    public string Color;
    public int Year;
    public string Brand;
    public string Model;
    public double FuelCapacity; // max yanacaq tutumu
    public double FuelFor1Km; // 1km yanacaq
    public double CurrentFuel; // yanacaq 
    public Vechile(
        string color,
        int year,
        string brand,
        string model,
        double fuelCapacity,
        double fuelFor1Km,
        double currentFuel)
    {
        Color = color;
        Year = year;
        Brand = brand;
        Model = model;
        FuelCapacity = fuelCapacity;
        FuelFor1Km =  fuelFor1Km;
        CurrentFuel = currentFuel;
    }
    public void ShowInfo()
    {
        Console.WriteLine(Color);
        Console.WriteLine(Year);
        Console.WriteLine(Brand);
        Console.WriteLine(Model);
        Console.WriteLine(FuelCapacity);
        Console.WriteLine(FuelFor1Km);
        Console.WriteLine(CurrentFuel);
    }
    public void Drive(double km)
    {
        if (km * FuelFor1Km <= CurrentFuel)
        {
            CurrentFuel -= km * FuelFor1Km;
            Console.WriteLine($"qalan yanacaq : {CurrentFuel}");
        }
        else
        {
            Console.WriteLine("hemin mesafeni gede bilmir.");
        }
    }
}