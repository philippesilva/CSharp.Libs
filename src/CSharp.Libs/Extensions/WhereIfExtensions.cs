using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Libs.Extensions
{
    public static class WhereIfExtensions
    {
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, bool> predicate)
            => condition ? source.Where(predicate) : source;
    }
}
