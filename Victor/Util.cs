using System.Linq;

namespace Victor
{
    internal static class Util
    {
        public static int h(params object[] objects)
        {
            return unchecked(objects.Select(o => o.GetHashCode()).Aggregate(17, (hash, next) => hash * 31 + next));
        }
    }
}
