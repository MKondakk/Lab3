using System;
using System.Runtime.InteropServices;

namespace lab3
{
    public class ArrayList<T> where T : IComparable
    {
        public T[] Array { get; set; }
        public int Size { get; set; }
        public ArrayList()
        {
            Size = 0;
        }

        public void Empty()
        {
            Array = System.Array.Empty<T>();
            Size = 0;
        }
        public bool isEmpty()
        {
            return (Size == 0);
        }
        public void Add(T item)
        {

            T[] temp = new T[Size + 1];
            for (int i = 0; i < Size; i++)
            {
                temp[i] = Array[i];
            }
            temp[Size++] = item;
            Array = temp;
        }

        public void HeapSort()
        {
            BuildHeap(Array);
        }
        public void BuildHeap(T[] array)
        {

            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Down(i, array.Length);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Swap(0, i);
                Down(0, i);
            }

            void Down(int root, int size)
            {
                int left = 2 * root + 1;
                int right = 2 * root + 2;
                int curr = root;

                if (left < size && array[curr].CompareTo(array[left]) < 0) { curr = left; }
                if (right < size && array[curr].CompareTo(array[right]) < 0) { curr = right; }
                if (curr == root) { return; }

                Swap(curr, root);
                Down(curr, size);
            }

            void Swap(int a, int b)
            {
                T temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }

        }


        public void Print()
        {
            Console.WriteLine("Array: ");
            foreach (T item in Array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine('\n');
        }
    }
}
