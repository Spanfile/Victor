﻿using System;
using System.Runtime.InteropServices;

namespace Victor
{
    [StructLayout(LayoutKind.Sequential)]
    public struct V2
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
        /// Gets the component at the index.
        /// </summary>
        /// <param name="n">Component index.</param>
        /// <returns></returns>
        public float this[int n]
        {
            get
            {
                switch (n)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new ArgumentOutOfRangeException("value");
                }
            }
        }

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

        public V3 V3() => new V3(x, y, 0);

        public V3 V3(float z) => new V3(x, y, z);

        /// <summary>
        /// Makes a tuple representing the vector.
        /// </summary>
        public T<float, float> tuple => new T<float, float>(x, y);

        public static V2 operator +(V2 a, V2 b) => new V2(a.x + b.x, a.y + b.y);

        public static V2 operator -(V2 a, V2 b) => new V2(a.x - b.x, a.y - b.y);

        public static V2 operator *(V2 a, float b) => new V2(a.x * b, a.y * b);

        public static V2 operator *(V2 a, V2 b) => new V2(a.x * b.x, a.y * b.y);

        public static V2 operator /(V2 a, float b) => new V2(a.x / b, a.y / b);

        public static V2 operator -(V2 a) => new V2(-a.x, -a.y);

        public override string ToString() => "(\{x}, \{y})";
    }
}
