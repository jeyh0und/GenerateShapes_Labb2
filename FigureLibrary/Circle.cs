using System.Numerics;

namespace FigureLibrary
{
    public class Circle : Shape2D
    {

        private Vector3 _center;
        private float _radius;

        public override float Circumference => MathF.PI * 2 * _radius;
        public override float Area => MathF.PI * MathF.Pow(_radius, 2);

        public override Vector3 Center => _center;
        public Circle(Vector2 center, float radius)
        {
            _radius = radius;
            _center = new(center, 0);
        }
        public override string ToString() => $"Circle \t@ ({_center.X:f2}, {_center.Y:f2}): r = {_radius:f2}";
    }
}
