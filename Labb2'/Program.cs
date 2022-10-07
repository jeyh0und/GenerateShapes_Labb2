using FigureLibrary;

do
{
    Console.Clear();

    Shape[] shapes = new Shape[20];
    float sumOfAreas = 0;

    for (int i = 0; i < shapes.Length; i++)
    {
        shapes[i] = Shape.GenerateShape();
        Console.WriteLine($"Shape {i + 1} is {shapes[i]}");
        sumOfAreas += shapes[i].Area;
    }
    Console.WriteLine();
    Console.WriteLine($"The average area of all the shapes is {(sumOfAreas / shapes.Length):f2} area units.");
    Console.WriteLine();
    Console.WriteLine("Press ESC to escape the loop!");
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape);