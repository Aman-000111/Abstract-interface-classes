using System;
public interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    double Height { get; set; }
    int Age { get; set; }

    void Eat();
    string Cry();
}

public class Dog : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

public class Cat : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice");
    }

    public string Cry()
    {
        return "Meow!";
    }
}

class ProgramA
{
    static void Main(string[] args)
    {
        // Create a Dog object
        Console.Write("Enter dog name: ");
        string dogName = Console.ReadLine();
        Dog dog = new Dog();
        dog.Name = dogName;

        // Set dog properties
        Console.Write("Enter dog height: ");
        dog.Height = double.Parse(Console.ReadLine());

        Console.Write("Enter dog colour: ");
        dog.Colour = Console.ReadLine();

        Console.Write("Enter dog age: ");
        dog.Age = int.Parse(Console.ReadLine());

        // Print dog properties
        Console.WriteLine($"Dog Name: {dog.Name}");
        Console.WriteLine($"Dog Height: {dog.Height}");
        Console.WriteLine($"Dog Colour: {dog.Colour}");
        Console.WriteLine($"Dog Age: {dog.Age}");

        // Execute dog methods
        dog.Eat();
        Console.WriteLine(dog.Cry());

        // Create a Cat object
        Console.Write("Enter cat name: ");
        string catName = Console.ReadLine();
        Cat cat = new Cat();
        cat.Name = catName;

        // Set cat properties
        Console.Write("Enter cat height: ");
        cat.Height = double.Parse(Console.ReadLine());

        Console.Write("Enter cat colour: ");
        cat.Colour = Console.ReadLine();

        Console.Write("Enter cat age: ");
        cat.Age = int.Parse(Console.ReadLine());

        // Print cat properties
        Console.WriteLine($"Cat Name: {cat.Name}");
        Console.WriteLine($"Cat Height: {cat.Height}");
        Console.WriteLine($"Cat Colour: {cat.Colour}");
        Console.WriteLine($"Cat Age: {cat.Age}");

        // Execute cat methods
        cat.Eat();
        Console.WriteLine(cat.Cry());

        // Create a list of animals
        var animals = new List<IAnimal>();
        animals.Add(dog);
        animals.Add(cat);

        // Print names of all animals
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}
