using Victor.Util;

namespace Victor
{
    /// <summary>
    /// 1-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    public sealed class T<A>
    {
        public readonly A a;
        
        public T(A a)
        {
            this.a = a;
        }

        public override string ToString() => "(a = \{a})";

        public override int GetHashCode() => a.GetHashCode();
    }

    /// <summary>
    /// 2-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    /// <typeparam name="B">Second type.</typeparam>
    public sealed class T<A, B>
    {
        public readonly A a;
        public readonly B b;

        public T(A a, B b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString() => "(a = \{a}, b = \{b})";

        public override int GetHashCode() => h(a, b);
    }

    /// <summary>
    /// 3-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    /// <typeparam name="B">Second type.</typeparam>
    /// <typeparam name="C">Third type.</typeparam>
    public sealed class T<A, B, C>
    {
        public readonly A a;
        public readonly B b;
        public readonly C c;

        public T(A a, B b, C c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override string ToString() => "(a = \{a}, b = \{b}, c = \{c})";

        public override int GetHashCode() => h(a, b, c);
    }

    /// <summary>
    /// 4-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    /// <typeparam name="B">Second type.</typeparam>
    /// <typeparam name="C">Third type.</typeparam>
    /// <typeparam name="D">Fourth type.</typeparam>
    public sealed class T<A, B, C, D>
    {
        public readonly A a;
        public readonly B b;
        public readonly C c;
        public readonly D d;

        public T(A a, B b, C c, D d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override string ToString() => "(a = \{a}, b = \{b}, c = \{c}, d = \{d})";

        public override int GetHashCode() => h(a, b, c, d);
    }

    /// <summary>
    /// 5-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    /// <typeparam name="B">Second type.</typeparam>
    /// <typeparam name="C">Third type.</typeparam>
    /// <typeparam name="D">Fourth type.</typeparam>
    /// <typeparam name="E">Fifth type.</typeparam>
    public sealed class T<A, B, C, D, E>
    {
        public readonly A a;
        public readonly B b;
        public readonly C c;
        public readonly D d;
        public readonly E e;

        public T(A a, B b, C c, D d, E e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public override string ToString() => "(a = \{a}, b = \{b}, c = \{c}, d = \{d}, e = \{e})";

        public override int GetHashCode() => h(a, b, c, d, e);
    }

    /// <summary>
    /// 6-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    /// <typeparam name="B">Second type.</typeparam>
    /// <typeparam name="C">Third type.</typeparam>
    /// <typeparam name="D">Fourth type.</typeparam>
    /// <typeparam name="E">Fifth type.</typeparam>
    /// <typeparam name="F">Sixth type.</typeparam>
    public sealed class T<A, B, C, D, E, F>
    {
        public readonly A a;
        public readonly B b;
        public readonly C c;
        public readonly D d;
        public readonly E e;
        public readonly F f;

        public T(A a, B b, C c, D d, E e, F f)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
        }

        public override string ToString() => "(a = \{a}, b = \{b}, c = \{c}, d = \{d}, e = \{e}, f = \{f})";

        public override int GetHashCode() => h(a, b, c, d, e, f);
    }

    /// <summary>
    /// 7-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    /// <typeparam name="B">Second type.</typeparam>
    /// <typeparam name="C">Third type.</typeparam>
    /// <typeparam name="D">Fourth type.</typeparam>
    /// <typeparam name="E">Fifth type.</typeparam>
    /// <typeparam name="F">Sixth type.</typeparam>
    /// <typeparam name="G">Seventh type.</typeparam>
    public sealed class T<A, B, C, D, E, F, G>
    {
        public readonly A a;
        public readonly B b;
        public readonly C c;
        public readonly D d;
        public readonly E e;
        public readonly F f;
        public readonly G g;

        public T(A a, B b, C c, D d, E e, F f, G g)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
        }

        public override string ToString() => "(a = \{a}, b = \{b}, c = \{c}, d = \{d}, e = \{e}, f = \{f}, g = \{g})";

        public override int GetHashCode() => h(a, b, c, d, e, f, g);
    }

    /// <summary>
    /// 8-tuple.
    /// </summary>
    /// <typeparam name="A">First type.</typeparam>
    /// <typeparam name="B">Second type.</typeparam>
    /// <typeparam name="C">Third type.</typeparam>
    /// <typeparam name="D">Fourth type.</typeparam>
    /// <typeparam name="E">Fifth type.</typeparam>
    /// <typeparam name="F">Sixth type.</typeparam>
    /// <typeparam name="G">Seventh type.</typeparam>
    /// <typeparam name="H">Eighth tuple.</typeparam>
    public sealed class T<A, B, C, D, E, F, G, H>
    {
        public readonly A a;
        public readonly B b;
        public readonly C c;
        public readonly D d;
        public readonly E e;
        public readonly F f;
        public readonly G g;
        public readonly H h;

        public T(A a, B b, C c, D d, E e, F f, G g, H h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
        }

        public override string ToString() => "(a = \{a}, b = \{b}, c = \{c}, d = \{d}, e = \{e}, f = \{f}, g = \{g}, h = \{h})";

        public override int GetHashCode() => h(a, b, c, d, e, f, g, h);
    }
}
