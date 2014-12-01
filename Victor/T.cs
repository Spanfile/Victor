using Victor.Util;

namespace Victor
{
    /// <summary>
    /// Tuples.
    /// </summary>
    public static class T
    {
        public static T<A> t<A>(A a) => new T<A>(a);
        public static T<A, B> t<A, B>(A a, B b) => new T<A, B>(a, b);
        public static T<A, B, C> t<A, B, C>(A a, B b, C c) => new T<A, B, C>(a, b, c);
        public static T<A, B, C, D> t<A, B, C, D>(A a, B b, C c, D d) => new T<A, B, C, D>(a, b, c, d);
        public static T<A, B, C, D, E> t<A, B, C, D, E>(A a, B b, C c, D d, E e) => new T<A, B, C, D, E>(a, b, c, d, e);
        public static T<A, B, C, D, E, F> t<A, B, C, D, E, F>(A a, B b, C c, D d, E e, F f) => new T<A, B, C, D, E, F>(a, b, c, d, e, f);
        public static T<A, B, C, D, E, F, G> t<A, B, C, D, E, F, G>(A a, B b, C c, D d, E e, F f, G g) => new T<A, B, C, D, E, F, G>(a, b, c, d, e, f, g);
        public static T<A, B, C, D, E, F, G, H> t<A, B, C, D, E, F, G, H>(A a, B b, C c, D d, E e, F f, G g, H h) => new T<A, B, C, D, E, F, G, H>(a, b, c, d, e, f, g, h);
    }

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
