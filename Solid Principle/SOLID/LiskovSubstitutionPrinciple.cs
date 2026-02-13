using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsAndSolid.SOLID
{
    internal abstract class Shape
    {
        public abstract int Area();
    }

    internal class Square(int SideLength) : Shape
    {
        public override int Area()
        {

            return SideLength * SideLength;
        }
    }

    internal class  Rectangle(int Width, int Height) : Shape
    {
        public override int Area()
        {
            return Width * Height;
        }
    }

    public class LiskovSubstitutionPrinciple
    {
        public void CalculateArea()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Square(7),
                new Rectangle(4, 6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}");
            }
        }
    }
}
