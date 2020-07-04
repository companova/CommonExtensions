using System;
using System.Collections.Generic;

namespace Companova.Common.Extensions
{
    /// <summary>
    /// Common Extensions for List
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Determines whether the List is Null or Empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">List</param>
        /// <returns>true if Null or Empty, otherwise false</returns>
        public static bool IsNullOrEmpty<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
                return true;

            return false;
        }
    }
}
