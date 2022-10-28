using System;

namespace ShapeLibrary
{
    /// <summary>
    /// Фигура - круг
    /// </summary>
    public class Circle : IAreaAvailable
    {
        private readonly double _radius;

        /// <exception cref="ArgumentException">Если радиус меньше нуля</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException($"radius ({radius}) cannot be less then 0");
            _radius = radius;
        }

        /// <summary>
        /// Возвращает площадь круга 
        /// </summary>
        /// <returns>double</returns>
        public double Area()
        {
            return _radius * _radius * Math.PI;
        }
        /// <summary>
        /// Возвращает площадь круга по заданному радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="System.ArgumentException"></exception>
        /// <returns>double</returns>
        public static double Area(double radius)
        {
            return new Circle(radius).Area();
        }
    }
}
