using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2_oop
{
    public class RectangleList<T> : IList<T>
    {
        T[] array = new T[5];
        int count = 0;

        public void Add(T element)
        {
            if (count < array.Length)
            {
                array[count] = element;
                count++;
            }
            else
            {
                this.Extend();
                this.Add(element);
            }
        }
        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < count; i++)
                if (array[i].Equals(element))
                    return true;
            return false;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(element))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T element)
        {
            if (count < array.Length)
            {
                if (index >= 0 && index <= count)
                {
                    for (int i = count; i > index; i--)
                    {
                        array[count] = array[count - 1];
                    }
                    array[index] = element;
                }
            }
            else
                this.Extend();
        }

        public bool IsFixedSize { get { return false; } }

        public bool IsReadOnly { get { return false; } }

        public bool Remove(T element)
        {
            if (this.Contains(element))
            {
                RemoveAt(IndexOf(element));
                return true;
            }
            else
                return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                count--;
                for (int i = index; i < count; i++)
                {
                    array[i] = array[i + 1];
                }
            }
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int j = arrayIndex;
            for (int i = 0; i < count; i++)
            {
                array[j] = this.array[i];
                j++;
            }
        }

        public int Count { get { return count; } }

        public bool IsSynchronized { get { return false; } }

        public object SyncRoot { get { return null; } }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }

        private void Extend()
        {
            if (array.Length < 1024)
            {
                T[] newArray = new T[2 * array.Length];
                CopyTo(newArray, 0);
                array = newArray;
            }
            else
            {
                T[] newArray = new T[array.Length + 8];
                CopyTo(newArray, 0);
                array = newArray;
            }
        }
    }
}
}
