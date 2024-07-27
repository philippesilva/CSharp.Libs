using System;
using System.Collections.Generic;

namespace CSharp.Libs.Extensions
{
    public static class ForEachExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            ArgumentNullException.ThrowIfNull(source);

            ArgumentNullException.ThrowIfNull(action);

            foreach (var element in source)
                action(element);
        }
    }
}
