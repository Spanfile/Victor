using System;

namespace Victor
{
    public sealed class V2
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
        /// Makes a new 2D vector.
        /// </summary>
        /// <param name="x">X component.</param>
        /// <param name="y">Y component.</param>
        public V2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Length (magnitude) of the vector.
        /// </summary>
        public float len => (float)Math.Sqrt(x * x + y * y);

        /// <summary>
        /// Squared length (magnitude) of the vector.
        /// </summary>
        public float len2 => x * x + y * y;

        /// <summary>
        /// Returns a normalized copy of the vector.
        /// </summary>
        public V2 unit => this / len;

        /// <summary>
        /// Normalizes the vector.
        /// </summary>
        public void normalize()
        {
            float l = (float)Math.Sqrt(x * x + y * y);
            x /= l;
            y /= l;
        }

        /// <summary>
        /// Distance from the vector to another.
        /// </summary>
        /// <param name="b">The other vector.</param>
        /// <returns></returns>
        public float dist(V2 b) => (this - b).len;

        /// <summary>
        /// Sum of the components.
        /// </summary>
        public float sum => x + y;

        public static V2 operator +(V2 a, V2 b) => new V2(a.x + b.x, a.y + b.y);

        public static V2 operator -(V2 a, V2 b) => new V2(a.x - b.x, a.y - b.y);

        public static V2 operator *(V2 a, float b) => new V2(a.x * b, a.y * b);

        public static V2 operator *(V2 a, V2 b) => new V2(a.x * b.x, a.y * b.y);

        public static V2 operator /(V2 a, float b) => new V2(a.x / b, a.y / b);

        public static V2 operator -(V2 a) => new V2(-a.x, -a.y);

        public override string ToString() => "(\{x}, \{y})";
    }
}
