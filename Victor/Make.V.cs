using System;

namespace Victor
{
    public static partial class Make
    {
        public const double PI = Math.PI;
        public const float PIF = (float)Math.PI;

        /// <summary>
        /// Makes a 2D vector.
        /// </summary>
        /// <param name="x">X component.</param>
        /// <param name="y">Y component.</param>
        /// <returns></returns>
        public static V2 V2(float x, float y) => new V2(x, y);

        /// <summary>
        /// Makes a (1, 0) vector.
        /// </summary>
        public static V2 X2 => new V2(1, 0);

        /// <summary>
        /// Makes a (0, 1) vector.
        /// </summary>
        public static V2 Y2 => new V2(0, 1);

        public static float angle(V2 a, V2 b) => ((a.unit * b.unit).sum + 1f) / 2f * PIF;

        public static float dot(V2 a, V2 b) => (a * b).sum;
    }
}
