using System;
using System.Math;

namespace Victor
{
    public static partial class Make
    {
        private const float PI2F = (float)PI * 2.0f;

        /// <summary>
        /// Makes a 2D vector.
        /// </summary>
        /// <param name="x">X component.</param>
        /// <param name="y">Y component.</param>
        /// <returns></returns>
        public static V2 V(float x, float y) => new V2(x, y);

        /// <summary>
        /// Makes a new 3D vector.
        /// </summary>
        /// <param name="x">X component.</param>
        /// <param name="y">Y component.</param>
        /// <param name="z">Z component.</param>
        /// <returns></returns>
        public static V3 V(float x, float y, float z) => new V3(x, y, z);

        /// <summary>
        /// Makes a (1, 0) vector.
        /// </summary>
        public static V2 X2 => new V2(1, 0);

        /// <summary>
        /// Makes a (0, 1) vector.
        /// </summary>
        public static V2 Y2 => new V2(0, 1);

        /// <summary>
        /// Makes a (1, 0, 0) vector.
        /// </summary>
        public static V3 X3 => new V3(1, 0, 0);

        /// <summary>
        /// Makes a (0, 1, 0) vector.
        /// </summary>
        public static V3 Y3 => new V3(0, 1, 0);

        /// <summary>
        /// Makes a (0, 0, 1) vector.
        /// </summary>
        public static V3 Z3 => new V3(0, 0, 1);

        /// <summary>
        /// Gets the angle between two 2D vectors.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns></returns>
        public static float angle(V2 a, V2 b) => ((a.unit * b.unit).sum + 1f) / PI2F;

        public static float angle(V3 a, V3 b) => ((a.unit * b.unit).sum + 1f) / PI2F;

        /// <summary>
        /// Gets the cross product of two 3D vectors.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns></returns>
        public static V3 cross(V3 a, V3 b) => new V3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y - b.x);

        /// <summary>
        /// Gets the dot product of two 2D vectors.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns></returns>
        public static float dot(V2 a, V2 b) => (a * b).sum;

        /// <summary>
        /// Gets the dot product of two 3D vectors.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns></returns>
        public static float dot(V3 a, V3 b) => (a * b).sum;

        /// <summary>
        /// Gets the distance between two 2D vectors.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns></returns>
        public static float dist(V2 a, V2 b) => (b - a).len;

        /// <summary>
        /// Gets the distance between two 3D vectors.
        /// </summary>
        /// <param name="a">First vector.</param>
        /// <param name="b">Second vector.</param>
        /// <returns></returns>
        public static float dist(V3 a, V3 b) => (b - a).len;
    }
}
