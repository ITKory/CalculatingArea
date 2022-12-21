
using AreaLibrary;

Triangle triangle = new(6, 8, 10);
Console.WriteLine(triangle.Area);
Console.WriteLine("Is Right Triangle?:"+triangle.ISRightTriangle());

Console.WriteLine(new Circle(11).Area);
Console.WriteLine(new Rectangle(12,6).Area);