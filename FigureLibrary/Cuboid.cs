using System.Numerics;

namespace FigureLibrary
{
    public class Cuboid : Shape3D
    {
        private Vector3 _center;
        private Vector3 _size;
        public override float Area => 2 * ((_size.X + _size.Y) + (_size.Z + _size.Y) + (_size.X + _size.Z));
        public override float Volume => _size.X * _size.Y * _size.Z;
        public override Vector3 Center => _center;
        public bool isCube => _size.X == _size.Y && _size.X == _size.Z;

        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }
        public Cuboid(Vector3 center, float side)
        {
            _center = center;
            _size.X = _size.Y = _size.Z = side;
        }
        public override string ToString()
        {
            return $"{(isCube ? "Cube" : "Cuboid")} \t@ ({_center.X:f2}, {_center.Y:f2}, {_center.Z:f2}): w = {_size.X:f2}, h = {_size.Y:f2}, l = {_size.Z:f2}";
        }
    }
}
