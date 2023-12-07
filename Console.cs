using System.Linq.Expressions;
using Stirnreihe.Data;

var line = new LineOfPerson();

do 
{
    Console.WriteLine("1) Add a person to the line\n2) Print the line\n3) Clear the line\n4) Exit");
    Console.Write("Your choice: ");
    int choice = int.Parse(Console.ReadLine()!);

    switch(choice)
    {
        case 1:
            Console.Write("First name: ");
            string firstName = Console.ReadLine()!;
            Console.Write("Last name: ");
            string lastName = Console.ReadLine()!;
            Console.WriteLine("Height: ");
            int height = int.Parse(Console.ReadLine()!);
            Person newPerson = new Person(firstName, lastName, height);
            line.AddToFront(newPerson);
            break;
        case 2:
            for(var node = line.First; node != null; node = node.Next)
            {
                Console.WriteLine(node.Person.ToString());
            }
            break;
        case 3:
            line.Clear();
            break;
        case 4:
            return;
        default: break;
    }

}while (true);