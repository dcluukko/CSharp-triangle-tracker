using System;
using System.Collections.Generic;
using System.Diagnostics;
public class Triangle 
{
    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle (int side1, int side2, int side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public void TriangleType()
    {
        Console.WriteLine(this.Side1);
        Console.WriteLine(this.Side2);
        Console.WriteLine(this.Side3);
        if (((this.Side1 + this.Side2) <= this.Side3) || ((this.Side1 + this.Side3) <= this.Side2) || ((this.Side2 + this.Side3) <= this.Side1)) {
            Console.WriteLine("You fool! This is not a triangle");
        }
        else if (this.Side1 == this.Side2 && this.Side1 == this.Side3 && this.Side2 == this.Side3) 
        {
            Console.WriteLine("Equilateral");
        }
        else if ((this.Side1 == this.Side2 && this.Side1 != this.Side3) || (this.Side1 == this.Side2 && this.Side2 != this.Side1) || (this.Side2 == this.Side3 && this.Side1 != this.Side2) || (this.Side2 == this.Side3 && this.Side1 != this.Side3) || (this.Side1 == this.Side3 && this.Side2 != this.Side1) || (this.Side1 == this.Side3 && this.Side2 != this.Side3))
        {
            Console.WriteLine("Isosceles");
        }
        else if ((this.Side1 != this.Side2) && (this.Side2 != this.Side3) && (this.Side1 != this.Side3)) 
        {
            Console.WriteLine("Scalene");
        }        
    }

}
public class Program 
{
    public static void Main()
    {
        Console.WriteLine("Enter Side 1:");
        int side1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Side 2:");
        int side2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Side 3:");
        int side3 = int.Parse(Console.ReadLine());

        Triangle yourTriangle = new Triangle(side1, side2, side3);
        yourTriangle.TriangleType();
    }
}