// See https://aka.ms/new-console-template for more information



public class Program
{
    public static void Main()
    {
        var carSystem = new CarSystem();

        var car1 = new Car
        {
            Id = 1,
            Brand = "Toyota",
            Model = "Camry",
            VIN = "ABC123VIN",
            ManufactureDate = new DateTime(2020, 5, 15),
            RegistrationDate = new DateTime(2020, 6, 1),
            Color = "Black",
            PassedInspection = true,
            InspectionDate = new DateTime(2023, 5, 1)
        };

        carSystem.Add(car1);

        Console.WriteLine("\nAll cars:");
        carSystem.ShowAll();
    }
}