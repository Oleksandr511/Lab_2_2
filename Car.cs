public class Car
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string VIN { get; set; }
    public string EngineNumber { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Color { get; set; }
    public bool PassedInspection { get; set; }
    public DateTime InspectionDate { get; set; }

    public override string ToString()
    {
        return $"{Brand} {Model}, VIN: {VIN}, Дата випуску: {ManufactureDate:yyyy-MM-dd}";
    }
}