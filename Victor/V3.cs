using System;
using System.Runtime.InteropServices;

namespace Victor
{
    [StructLayout(LayoutKind.Sequential)]
    public struct V3
    {
        /// <summary>
        /// X component.
        /// </summary>
        public float x;
        /// <summary>
        /// Y component.
        /// </summary>
        public float y;
        /// <summary>
        /// Z component.
        /// </summary>
        public float z;

        /// <summary>
        /// Makes a new 3D vector.
        /// </summary>
        /// <param name="x">X component.</param>
        /// <param name="y">Y component.</param>
        /// <param name="z">Z component.</param>
        public V3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Makes a new 3D vector from a 2D vector.
        /// </summary>
        /// <param name="xy">XY components.</param>
        /// <param name="z">Z component.</param>
        public V3(V2 xy, float z)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        public float len => (float)Math.Sqrt(x * x + y * y + z * z);

        public float len2 => x * x + y * y + z * z;

        public V3 unit => this / len;

        public void normalize()
        {
            float l = (float)Math.Sqrt(x * x + y * y + z * z);
            x /= l;
            y /= l;
            z /= l;
        }

        public float dist(V3 b) => (this - b).len;

        public float sum => x + y + z;

        public static V3 operator +(V3 a, V3 b) => new V3(a.x + b.x, a.y + b.y, a.z + b.z);

        public static V3 operator -(V3 a, V3 b) => new V3(a.x - b.x, a.y - b.y, a.z - b.z);

        public static V3 operator *(V3 a, float b) => new V3(a.x * b, a.y * b, a.z * b);

        public static V3 operator *(V3 a, V3 b) => new V3(a.x * b.x, a.y * b.y, a.z * b.z);

        public static V3 operator /(V3 a, float b) => new V3(a.x / b, a.y / b, a.z / b);

        public static V3 operator -(V3 a) => new V3(-a.x, -a.y, -a.z);

        public override string ToString() => "(\{x}, \{y}, \{z})";
    }
}
