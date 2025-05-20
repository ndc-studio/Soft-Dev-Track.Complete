using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GenericSpace
{
    public static class FilterUtility
    {
        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T, bool> condition)
        {
            return items.Where(condition);
        }
    }
}