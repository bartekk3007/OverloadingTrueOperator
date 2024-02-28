using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector
{
    public int X {  get; set; }
    public int Y { get; set; }
    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }
    public static bool operator true(Vector v)
    {
        if(v.X <= v.Y)
        {
            Console.WriteLine("True - true");
            return true;
        }
        else
        {
            Console.WriteLine("True - false");
            return false;
        }
    }
    public static bool operator false(Vector v)
    {
        if(v.X > v.Y)
        {
            Console.WriteLine("False - true");
            return true;
        }
        else
        {
            Console.WriteLine("False - false");
            return false;
        }
    }
}
