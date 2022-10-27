using System;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException($"radius ({radius}) cannot be less then 0");
            _radius = radius;
        }
        public override double Area()
        {
            return _radius * _radius * Math.PI / 2;
        }

        public static double Area(double radius)
        {
            return new Circle(radius).Area();
        }
    }
}
