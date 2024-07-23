using System;

public class Coffee
{
    private string name;
    private double price;

   
    public string Name
    {
        set { name = value; }
    }

    public double Price
    {
        set
        {
            if (value > 0)
            {
                price = value;
            }
            else
            {
                throw new ArgumentException("Price must be greater than 0");
            }
        }
    }

    public Coffee(string name, double price)
    {
        Name = name;
        Price = price;
    }

    private void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Price: {price}");
    }

    public void PrintInfo()
    {
        GetInfo();
        Console.WriteLine("Enjoy your coffee!");
    }

    public static void Main(string[] args)
    {
        Coffee coffee = new Coffee("Latte", 5);

        coffee.PrintInfo();
    }
}
