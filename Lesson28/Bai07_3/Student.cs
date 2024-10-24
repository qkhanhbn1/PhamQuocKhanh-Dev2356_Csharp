using System;

public class InvalidMarkException : Exception
{
    public InvalidMarkException(string message) : base(message)
    {
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    private double theoryMark;
    private double labMark;

    public double TheoryMark
    {
        get { return theoryMark; }
        set
        {
            if (value < 0 || value > 10)
                throw new InvalidMarkException("Điểm lý thuyết phải nằm trong khoảng từ 0 đến 10.");
            theoryMark = value;
        }
    }

    public double LabMark
    {
        get { return labMark; }
        set
        {
            if (value < 0 || value > 10)
                throw new InvalidMarkException("Điểm phòng thí nghiệm phải nằm trong khoảng từ 0 đến 10.");
            labMark = value;
        }
    }

    public Student(int id, string name, double theoryMark, double labMark)
    {
        Id = id;
        Name = name;
        TheoryMark = theoryMark;
        LabMark = labMark;
    }
}
