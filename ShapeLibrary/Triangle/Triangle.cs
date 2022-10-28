using System;

namespace ShapeLibrary
{
    /// <summary>
    /// Фигура треугольник
    /// </summary>
    public class Triangle : IAreaAvailable, ICanBeRightangle
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        /// <exception cref="ArgumentException">Если один из аргументов меньше или равен 0</exception>
        /// <exception cref="ArgumentException">Если одна из сторон длинее чем сумма двух других</exception>
        public Triangle(double a, double b, double c)
        {
            //Не может быть отрицательных значений сторон или 0
            if (a <= 0)
                throw new ArgumentException($"{nameof(a)} ({a}) cannot be less or equal 0");
            if (b <= 0)
                throw new ArgumentException($"{nameof(b)} ({b}) cannot be less or equal 0");
            if (c <= 0)
                throw new ArgumentException($"{nameof(c)} ({c}) cannot be less or equal 0");
            //Каждая сторона должна быть короче суммы длин двух других сторон
            if (a >= b + c)
                throw new ArgumentException($"{nameof(a)} ({a}) cannot be more or equal b + c ({b + c})");
            if (b >= c + a)
                throw new ArgumentException($"{nameof(b)} ({b}) cannot be more or equal a + c ({a + c})");
            if (c >= a + b)
                throw new ArgumentException($"{nameof(c)} ({c}) cannot be more or equal b + a ({b + a})");

            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        /// <returns>double</returns>
        public double Area()
        {
            //Находим площадь через полупериметр
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <summary>
        /// Возвращает площадь треугольника с заданными сторонами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException">Если один из аргументов меньше или равен 0</exception>
        /// <exception cref="ArgumentException">Если одна из сторон длинее чем сумма двух других</exception>
        /// <returns>double</returns>
        public static double Area(double a, double b, double c)
        {
            return new Triangle(a, b, c).Area();
        }

        /// <summary>
        /// Возвращает, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsRightangle()
        {
            //В прямоугольном треугольнике квадрат гипотенузы
            //равен сумме квадратов катетов
            //гипотенуза - самая большая сторона
            if(_c >= _a && _c >= _b)
                return _c * _c == (_a * _a + _b * _b);
            else if (_b >= _a && _b >= _c)
                return _b * _b == (_a * _a + _c * _c);
            else 
                return _a * _a == (_c * _c + _b * _b);
        }

        /// <summary>
        /// Возвращает, является ли треугольник прямоугольным
        /// </summary>
        /// <exception cref="ArgumentException">Если один из аргументов меньше или равен 0</exception>
        /// <exception cref="ArgumentException">Если одна из сторон длинее чем сумма двух других</exception>
        /// <returns>True/False</returns>
        public static bool IsRightangle(double a, double b, double c)
        {
            return new Triangle(a, b, c).IsRightangle();
        }
    }
}
