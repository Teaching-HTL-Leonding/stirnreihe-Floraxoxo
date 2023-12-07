namespace Stirnreihe.Data;

public class Node
{
    public Node(Person person)
    {
        Person = person;
    }
    public Person Person {get; set;}
    public Node? Next {get; set;}
}
