using ShapeLibrary;

Console.WriteLine("Треугольник со сторонами 5, 4, 3");
var triangle = new Triangle(5, 4, 3);
Console.WriteLine($"Площадь треугольника: {triangle.Area()}");
Console.WriteLine($"Является прямоугольным: {triangle.IsRightangle()}");
Console.WriteLine("Треугольник со сторонами 20, 15, 7");
triangle = new Triangle(20, 15, 7);
Console.WriteLine($"Площадь треугольника: {triangle.Area()}");
Console.WriteLine($"Является прямоугольным: {triangle.IsRightangle()}");

Console.WriteLine("Круг");
var circle = new Circle(15);
Console.WriteLine($"Площадь круга: {circle.Area()}");
circle = new Circle(15);
Console.WriteLine($"Площадь круга: {circle.Area()}");

Console.WriteLine("Коллекция элементов");
var list = new List<IAreaAvailable>
{
    triangle,
    circle
};
foreach (var shape in list)
{
    Console.WriteLine($"Площадь фигуры: {shape.Area()}");
}

Console.ReadLine();