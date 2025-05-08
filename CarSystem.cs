public class CarSystem
{
    private List<Car> _cars = new();
    private List<Car> _deletedCars = new();

    public void Add(Car car) => _cars.Add(car);

    public void Delete(int id)
    {
        var car = _cars.FirstOrDefault(c => c.Id == id);
        if (car != null)
        {
            _cars.Remove(car);
            _deletedCars.Add(car);
        }
    }

    public void ShowAll() => _cars.ForEach(Console.WriteLine);

    public void ShowDeleted() => _deletedCars.ForEach(Console.WriteLine);
}