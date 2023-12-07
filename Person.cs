namespace Stirnreihe.Data;

public class Person
{
    public Person(string firstName, string lastName, int height)
    {
        FirstName = firstName;
        LastName = lastName;
        Height = height;
    }
    public string? FirstName { get; set; } 
    public string? LastName { get; set; }
    public int Height { get; set; }
    public override string ToString()
    {
        return $"{LastName}, {FirstName} ({Height} cm)";
    }
}
