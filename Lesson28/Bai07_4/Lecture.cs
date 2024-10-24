using System;

public class AmountException : Exception
{
    public AmountException(string message) : base(message)
    {
    }
}

public class Lecture
{
    public string Name { get; set; }
    private double salary;
    private double bonus;

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 60000)
                throw new AmountException("Mức lương phải ít nhất là 60.000");
            salary = value;
        }
    }

    public double Bonus
    {
        get { return bonus; }
        set
        {
            if (value > 10000)
                throw new AmountException("Tiền thưởng không thể vượt quá 10.000");
            bonus = value;
        }
    }

    public Lecture(string name, double salary, double bonus)
    {
        Name = name;
        Salary = salary;
        Bonus = bonus;
    }
}