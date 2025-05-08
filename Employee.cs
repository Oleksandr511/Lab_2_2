public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string PassportInfo { get; set; }
    public int PositionId { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Ім'я: {FullName}, Вік: {Age}, Стать: {Gender}, Телефон: {Phone}";
    }
}