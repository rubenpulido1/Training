// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

// Pt. 15: LINQ

List<int> scores = [95, 92, 100, 80, 30, 67];
int[] scores2 = [95, 92, 100, 80, 30, 67];

// Console.WriteLine(scores2);

var scoreQuery = scores.Where(s => s > 80).OrderByDescending(s => s);

IEnumerable<int> scoreQ =
  from score in scores
  where score > 80
  select score;

foreach (var score in scoreQ)
{
  Console.WriteLine(score);
}


IOrderedEnumerable<int> ordered = scores.OrderBy(s => s);
IEnumerable<int> upcasted = ordered;  // ← this is upcasting



// Pt 19 OOP w/ derived or abstract classes, overides | IEnumerable
var p1 = new Person("Scott", "Hanselman", new DateOnly(1970, 1, 1));
var p2 = new Person("David", "Fowler", new DateOnly(1986, 1, 1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [p1, p2];

foreach (var person in people)
{
  // Console.WriteLine($"{person}");
  foreach (var pet in person.Pets)
  {
    // Console.WriteLine($"       {pet}");

  }
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
  public string First { get; } = firstName;

  public string Last { get; } = lastName;

  public DateOnly Birthday { get; } = birthday;

  public List<Pet> Pets { get; } = new();

  // Overriding object class method ToString()
  public override string ToString()
  {
    return $"{First} {Last}";
  }
}


// Abstract class
public abstract class Pet(string firstName)
{
  public string First { get; } = firstName;

  // Abstract method
  public abstract string MakeNoise();

  public override string ToString()
  {
    /* 
      C# uses runtime type information (via the virtual method table) to 
      resolve the correct override of MakeNoise().
    */ 
    return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
  }
}

public class Cat (string firstName): Pet(firstName)
{
  // Overriding the MakeNoise method from the abstract class
  public override string MakeNoise() => "meow";
}

public class Dog (string firstName) : Pet(firstName)
{
  public override string MakeNoise() => "bark";
}

