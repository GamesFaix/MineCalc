using System.Collections.Generic;
using System.Linq;

namespace MineCalc
{
    static class EnumerableExtensions
    {
        public static bool IsEqualSet<T>(this IEnumerable<T> a, IEnumerable<T> b) =>
            !a.Except(b).Any();
    }
}
