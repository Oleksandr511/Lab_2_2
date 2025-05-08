using System;
using System.Collections.Generic;

public class CarSystem
{
    private List<Car> _cars = new();
    private List<Car> _deleted = new();

    public void Add(Car car) => _cars.Add(car);

    public void Delete(int id)
    {
        var car = _cars.Find(c => c.Id == id);
        if (car != null)
        {
            _cars.Remove(car);
            _deleted.Add(car);
        }
    }

    public void ShowAll()
    {
        foreach (var car in _cars)
            Console.WriteLine(car);
    }

    public void ShowDeleted()
    {
        foreach (var car in _deleted)
            Console.WriteLine(car);
    }
}
