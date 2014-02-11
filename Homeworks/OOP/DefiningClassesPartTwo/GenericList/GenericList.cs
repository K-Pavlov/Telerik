using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T> where T : IComparable<T>
    {
        private readonly uint capacity;
        private T[] list;
        private int placeToAdd;

        public T[] List
        {
            get { return list; }
            set { list = value; }
        }

        public GenericList(uint capacity)
        {
            this.capacity = capacity;
            this.placeToAdd = 0;
            this.list = new T[capacity];
        }

        public int Size()
        {
            return this.list.Length;
        }

        public void AddElement(T element)
        {
            if (this.placeToAdd == this.list.Length)
            {
                T[] newList = new T[this.list.Length * 2];
                for (int i = 0; i < this.list.Length; i++)
                {
                    newList[i] = this.list[i];
                }
                this.list = newList;
            }
            this.list[this.placeToAdd++] = element;
        }

        public T GetElement(uint index)
        {
            if (index < 0 || index > this.list.Length - 1)
            {
                throw new IndexOutOfRangeException("Index");
            }
            return this.list[index];
        }
        public void RemoveElement(uint index)
        {
            if (index < 0 || index >= this.list.Length)
            {
                throw new IndexOutOfRangeException("Index");
            }

            T[] newList = new T[this.list.Length];
            for (int i = 0, j = 0; i < this.list.Length - 1; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                newList[i] = this.list[j];
            }
            this.list = newList;
            Array.Resize<T>(ref list, this.placeToAdd - 1);
        }

        public void InsterElement(uint index, T element)
        {
            if (index < 0 || index >= this.list.Length - 1)
            {
                throw new IndexOutOfRangeException("Index");
            }

            T[] newList = new T[this.list.Length - 1];

            for (int i = 0, j = 0; i < this.list.Length - 1; i++, j++)
            {
                if (i == index)
                {
                    newList[i] = element;
                    i++;
                }
                newList[i] = this.list[j];
            }
            this.list = newList;
        }

        public void ClearList()
        {
            Array.Clear(this.list, 0, this.list.Length);
            placeToAdd = 0;
        }

        public int FindElementByVal(T val)
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i].CompareTo(val) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public T Min()
        {
            T[] sorted = this.list;
            Array.Sort(sorted);
            return sorted[0];
        }

        public T Max()
        {
            T[] sorted = this.list;
            Array.Sort(sorted);
            return sorted[this.list.Length - 1];
        }

        public override string ToString()
        {
            if (this.placeToAdd == 0)
                return "Empty list.";

            string[] info = new string[this.placeToAdd];

            for (int i = 0; i < this.placeToAdd - 1; i++)
                info[i] = String.Format("{0}: {1}", i, this.list[i].ToString());

            return String.Join(Environment.NewLine, info);
        }
    }
}
