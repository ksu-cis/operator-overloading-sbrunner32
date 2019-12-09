using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMath
{
    public class Vector3
    {
        double X;
        double Y;
        double Z;

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }


        // Vector Addition
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public void Add(Vector3 other)
        {
            this.X += other.X;
            this.Y += other.Y;
            this.Z += other.Z;
        }

        // Vector Subtraction 

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        // Vector Scaling 
        public static Vector3 operator *(double s, Vector3 v)
        {
            return new Vector3(v.X * s, v.Y * s, v.Z *s);
        }

        public static Vector3 operator *( Vector3 v, double s)
        {
            return new Vector3(v.X * s, v.Y * s, v.Z * s);
        }

        // Vector Comparison
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }

        public static readonly Vector3 Zero = new Vector3(0, 0, 0);

        public static bool operator true(Vector3 a)
        {
            return Vector3.Zero != a;
        }

        public static bool operator false(Vector3 a)
        {
            return Vector3.Zero == a;
        }


    }
}
