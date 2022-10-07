using System.Numerics;

namespace FigureLibrary
{
    public class Rectangle : Shape2D
    {
        private Vector2 _size;
        private Vector3 _center;
        public override float Circumference => (_size.X + _size.Y) * 2;
        public override float Area => _size.X * _size.Y;
        public override Vector3 Center => _center;
        public bool isSquare => _size.X == _size.Y;
        public Rectangle(Vector2 center, Vector2 size)
        {
            _size = size;
            _center = new(center, 0);
        }
        public Rectangle(Vector2 center, float side)
        {
            _center = new(center, 0);
            _size.X = _size.Y = side;
        }
        public override string ToString()
        {

            return $"{(isSquare ? "Square" : "Rectangle")} \t@ ({_center.X:f2}, {_center.Y:f2}): w = {_size.X:f2}, h = {_size.Y:f2}";
        }
    }
}
