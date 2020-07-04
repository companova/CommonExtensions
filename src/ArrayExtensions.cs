using System;

namespace Companova.Common.Extensions
{
    /// <summary>
    /// Common Extensions for Array
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Shuffles the content of the Array in place.
        /// Uses Random function to randomize positions.
        /// </summary>
        /// <param name="array">Array</param>
        public static void Shuffle(this Array array)
        {
            Random rnd = new Random();

            // Shuffle
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int j = rnd.Next(i);
                object temp = array.GetValue(i);
                array.SetValue(array.GetValue(j), i);
                array.SetValue(temp, j);
            }
        }
    }
}
