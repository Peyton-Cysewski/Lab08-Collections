using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Collections.classes
{
    class Library<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count;

        /// <summary>
        /// Adds an item to the generic collection
        /// </summary>
        /// <param name="item">Item being added</param>
        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length + 5);
            }
            items[count++] = item;
        }

        /// <summary>
        /// Returns the count of all the items in a collection
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return count;
        }

        /// <summary>
        /// The method that allows a foreach to work on this custom generic collection
        /// </summary>
        /// <returns>Yield returns each item in the collection</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        /// <summary>
        /// Supposedly magic leftover from an older time
        /// </summary>
        /// <returns>The enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
