// Grade Calculator

using System;

class Program
{
    static void GradeCalculator()
    {
        Console.Write("Enter your numerical grade (0-100): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
            Console.WriteLine("Grade: A");
        else if (grade >= 80)
            Console.WriteLine("Grade: B");
        else if (grade >= 70)
            Console.WriteLine("Grade: C");
        else if (grade >= 60)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }

  // Ticket Price Calculator
    static void TicketPriceCalculator()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket price: GHC7");
        else
            Console.WriteLine("Ticket price: GHC10");
    }



  // main menu

  static void Main(string[] args)
  {
    while (true)
    {
      Console.WriteLine("\nSelect an application:");
      Console.WriteLine("1. Grade Calculator");
      Console.WriteLine("2. Ticket Price Calculator");
      Console.Write("Enter choice (1-2): ");


      string choice = Console.ReadLine();
      switch (choice)
      {
        case "1":
          GradeCalculator();
          break;
        case "2":
          TicketPriceCalculator();
          break;

        default:
          Console.WriteLine("Invalid choice. Try again.");
          break;
      }
    }
  }
}
