using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor
{
    public static class Make
    {
        /// <summary>
        /// Makes a 1-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <param name="a">First value.</param>
        /// <returns></returns>
        public static T<A> T<A>(A a) => new T<A>(a);

        /// <summary>
        /// Makes a 2-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <typeparam name="B">Second type.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        /// <returns></returns>
        public static T<A, B> T<A, B>(A a, B b) => new T<A, B>(a, b);

        /// <summary>
        /// Makes a 3-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <typeparam name="B">Second type.</typeparam>
        /// <typeparam name="C">Third type.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        /// <param name="c">Third value.</param>
        /// <returns></returns>
        public static T<A, B, C> T<A, B, C>(A a, B b, C c) => new T<A, B, C>(a, b, c);

        /// <summary>
        /// Makes a 4-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <typeparam name="B">Second type.</typeparam>
        /// <typeparam name="C">Third type.</typeparam>
        /// <typeparam name="D">Fourth type.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        /// <param name="c">Third value.</param>
        /// <param name="d">Fourth value.</param>
        /// <returns></returns>
        public static T<A, B, C, D> T<A, B, C, D>(A a, B b, C c, D d) => new T<A, B, C, D>(a, b, c, d);

        /// <summary>
        /// Makes a 5-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <typeparam name="B">Second type.</typeparam>
        /// <typeparam name="C">Third type.</typeparam>
        /// <typeparam name="D">Fourth type.</typeparam>
        /// <typeparam name="E">Fifth type.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        /// <param name="c">Third value.</param>
        /// <param name="d">Fourth value.</param>
        /// <param name="e">Fifth value.</param>
        /// <returns></returns>
        public static T<A, B, C, D, E> T<A, B, C, D, E>(A a, B b, C c, D d, E e) => new T<A, B, C, D, E>(a, b, c, d, e);

        /// <summary>
        /// Makes a 6-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <typeparam name="B">Second type.</typeparam>
        /// <typeparam name="C">Third type.</typeparam>
        /// <typeparam name="D">Fourth type.</typeparam>
        /// <typeparam name="E">Fifth type.</typeparam>
        /// <typeparam name="F">Sixth type.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        /// <param name="c">Third value.</param>
        /// <param name="d">Fourth value.</param>
        /// <param name="e">Fifth value.</param>
        /// <param name="f">Sixth value.</param>
        /// <returns></returns>
        public static T<A, B, C, D, E, F> T<A, B, C, D, E, F>(A a, B b, C c, D d, E e, F f) => new T<A, B, C, D, E, F>(a, b, c, d, e, f);

        /// <summary>
        /// Makes a 7-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <typeparam name="B">Second type.</typeparam>
        /// <typeparam name="C">Third type.</typeparam>
        /// <typeparam name="D">Fourth type.</typeparam>
        /// <typeparam name="E">Fifth type.</typeparam>
        /// <typeparam name="F">Sixth type.</typeparam>
        /// <typeparam name="G">Seventh type.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        /// <param name="c">Third value.</param>
        /// <param name="d">Fourth value.</param>
        /// <param name="e">Fifth value.</param>
        /// <param name="f">Sixth value.</param>
        /// <param name="g">Seventh value.</param>
        /// <returns></returns>
        public static T<A, B, C, D, E, F, G> T<A, B, C, D, E, F, G>(A a, B b, C c, D d, E e, F f, G g) => new T<A, B, C, D, E, F, G>(a, b, c, d, e, f, g);

        /// <summary>
        /// Makes an 8-tuple.
        /// </summary>
        /// <typeparam name="A">First type.</typeparam>
        /// <typeparam name="B">Second type.</typeparam>
        /// <typeparam name="C">Third type.</typeparam>
        /// <typeparam name="D">Fourth type.</typeparam>
        /// <typeparam name="E">Fifth type.</typeparam>
        /// <typeparam name="F">Sixth type.</typeparam>
        /// <typeparam name="G">Seventh type.</typeparam>
        /// <typeparam name="H">Eighth type.</typeparam>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        /// <param name="c">Third value.</param>
        /// <param name="d">Fourth value.</param>
        /// <param name="e">Fifth value.</param>
        /// <param name="f">Sixth value.</param>
        /// <param name="g">Seventh value.</param>
        /// <param name="h">Eighth value.</param>
        /// <returns></returns>
        public static T<A, B, C, D, E, F, G, H> T<A, B, C, D, E, F, G, H>(A a, B b, C c, D d, E e, F f, G g, H h) => new T<A, B, C, D, E, F, G, H>(a, b, c, d, e, f, g, h);
    }
}
