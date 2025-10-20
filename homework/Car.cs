class Car
{
    public string Brand { get; set; } 
    public string Model { get; set; } 
    public int Year { get; set; }     
    public int Mileage { get; set; } // в км

    public void PrintInfo()
    {
        Console.WriteLine($"{Brand}, {Model}, {Year}, {Mileage}");
    }
}
