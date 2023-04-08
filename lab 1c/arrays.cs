using System;

public class Program {
    public void Main()
    {
        string[] cars = {"Volo"; "BMW"; "Ford"; "Mazda"};
        cars[0] = "Opel";
        Console.WriteLine(cars[0]);

        string[] cars = {"Volo"; "BMW"; "Ford"; "Mazda"};
        Console.WriteLine(cars.Length);

        string[] cars = {"Volo"; "BMW"; "Ford"; "Mazda"};
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        string[] cars = {"Volo"; "BMW"; "Ford"; "Mazda"};
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}