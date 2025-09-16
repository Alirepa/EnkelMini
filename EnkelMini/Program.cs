using System;


class Program
{
    static void Main(string[] args) { 
        Console.WriteLine("Välkommen till EnkelMini!");
        Console.WriteLine("1 för addition");
        Console.WriteLine("2 för subtraktion");
        Console.WriteLine("3 för multiplikation");
        Console.WriteLine("4 för division");
       
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ange första talet:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ange andra talet:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (choice) {
            case 1:
                Addition(num1, num2);
                break;
            case 2:
                Subtraction(num1, num2);
                break;
            case 3:
                Multiplication(num1, num2);
                break;
            case 4:
                Division(num1, num2);
                break;
            default:
                Console.WriteLine("Ogiltigt val");
                break;
        }
    }



    static void Addition(double num1, double num2)
    {
        var sum = num1 + num2;
        Console.WriteLine($"Addition sum: {sum}");
    } 
    static void Subtraction(double num1, double num2)
    {
        var sum = num1 - num2;
        Console.WriteLine($"Subtractino sum: {sum}");
    }
    static void Multiplication(double num1, double num2)
    {
        var sum = num1 * num2;
        Console.WriteLine($"Multiplication sum: {sum}");
    }
    static void Division(double num1, double num2)
    {
        var sum = num1 / num2;
        Console.WriteLine($"Division sum: {sum}");
    }
}