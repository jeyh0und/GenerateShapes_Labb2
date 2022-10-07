using System.Numerics;

namespace FigureLibrary
{
    public abstract class Shape
    {
        enum ShapeTypes
        {
            Circle,
            Cuboid,
            Cube,
            Rectangle,
            Square,
            Sphere
        }

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        public static Shape GenerateShape()
        {
            Random random = new Random();
            ShapeTypes randomShape = (ShapeTypes)random.Next(0, 5);

            float x = (float)random.NextDouble() * 20 - 10;
            float y = (float)random.NextDouble() * 20 - 10;
            float z = (float)random.NextDouble() * 20 - 10;
            float radius = (float)random.NextDouble() * 10;
            float width = (float)random.NextDouble() * 10;

            switch (randomShape)
            {
                case ShapeTypes.Circle:
                    return new Circle(new Vector2(x, y), radius);
                case ShapeTypes.Sphere:
                    return new Sphere(new Vector3(x, y, z), radius);
                case ShapeTypes.Cuboid:
                    return new Cuboid(new Vector3(x, y, z), new Vector3(x, y, z));
                case ShapeTypes.Cube:
                    return new Cuboid(new Vector3(x, y, z), width);
                case ShapeTypes.Rectangle:
                    return new Rectangle(new Vector2(x, y), new Vector2(x, y));
                case ShapeTypes.Square:
                    return new Rectangle(new Vector2(x, y), width);
                default: return null;
            }
        }
    }
}