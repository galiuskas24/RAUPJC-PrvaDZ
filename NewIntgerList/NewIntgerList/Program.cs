using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewIntegerList
{
    public interface IIntegerList
    {
        /// <summary> 
        /// Adds an item to the collection. 
        /// </summary> 
        void Add(int item);

        /// <summary> 
        /// Removes the first occurrence of an item from the collection. 
        /// If the item was not found, method does nothing. 
        /// </summary>
        bool Remove(int item);

        /// <summary> 
        /// Removes the item at the given index in the collection. 
        /// </summary> 
        bool RemoveAt(int index);

        /// <summary> 
        /// Returns the item at the given index in the collection.
        /// </summary> 
        int GetElement(int index);

        /// <summary> 
        /// Returns the index of the item in the collection. 
        /// If item is not found in the collection, method returns -1. 
        /// </summary> 
        int IndexOf(int item);

        /// <summary>
        /// Readonly property. Gets the number of items contained in the collection. 
        /// </summary> 
        int Count { get; }

        /// <summary> 
        /// Removes all items from the collection. 
        /// </summary> 
        void Clear();

        /// <summary> 
        /// Determines whether the collection contains a specific value. 
        /// </summary> 
        bool Contains(int item);

    }

    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private static int counter = 0;


        /// <summary>
        /// Basic constructor
        /// </summary>
        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        /// <summary>
        /// Init IntegerList on (int) initialSize size.
        /// </summary>
        /// <param name="initialSize"></param>
        /// 
        public IntegerList(int initialSize)
        {
            if (initialSize <= 0)
            {
                throw new IndexOutOfRangeException("Broj mora bit veci od nule!!!");
            }
            _internalStorage = new int[initialSize];
        }

        public int Count
        {
            get
            {
                return counter;
            }
        }

        public void Add(int item)
        {
            if (_internalStorage.Length == Count)
            {
                //"realloc" -- Create empty array 2 * (old size)
                int[] temp = new int[_internalStorage.Length * 2];
                _internalStorage.CopyTo(temp, 0);
                _internalStorage = temp;

            }

            // add item to new array
            _internalStorage[Count] = item;
            ++counter;

        }

        public int GetElement(int index)
        {
            if (index < Count && index >= 0)
            {
                return _internalStorage[index];
            }

            throw new IndexOutOfRangeException("Ne postoji taj element!!!");
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                _internalStorage[i] = 0;
            }

            counter = 0;
        }

        public int IndexOf(int item)
        {
            int index = Array.IndexOf(_internalStorage, item);

            if (index != -1)
            {
                return index;
            }
            return -1;

        }

        public bool Contains(int item)
        {
            if (IndexOf(item) == -1)
            {
                return false;
            }

            return true;
        }

        public bool Remove(int item)
        {
            return RemoveAt(IndexOf(item));
        }

        public bool RemoveAt(int index)
        {
            //last index in array
            int lastElement = Count - 1;
            if (index > lastElement || index < 0)
            {
                return false;
            }
            for (int i = index; i < lastElement; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }


            //pobrisi zadnji član ???
            _internalStorage[lastElement] = 0;
            --counter;
            return true;
        }

    }

}
