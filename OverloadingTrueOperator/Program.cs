using System;

class Program
{
    public static void Main(string[] args)
    {
        Vector v1 = new Vector(2, 3);
        Console.WriteLine(v1);
        if(v1)
        {
            Console.WriteLine($"{v1.X} <= {v1.Y}");
        }
        else
        {
            Console.WriteLine($"{v1.X} > {v1.Y}");
        }

        Vector v2 = new Vector(5, 2);
        Console.WriteLine(v2);
        if (v2)
        {
            Console.WriteLine($"{v2.X} <= {v2.Y}");
        }
        else
        {
            Console.WriteLine($"{v2.X} > {v2.Y}");
        }
    }
}