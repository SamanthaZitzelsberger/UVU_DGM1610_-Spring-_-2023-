using System;

public class Program
{
    public void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i <= 10; i = i + 2)
        {
            Console.WriteLine(i);
        }

        string[] cars = {"Volo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars)
        {
            Console.WrtieLine(i);
        }
    }
}