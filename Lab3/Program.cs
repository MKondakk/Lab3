using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ArrayList<int> list1 = new ArrayList<int>();
                list1.Add(4);
                list1.Add(5);
                list1.Add(7);
                list1.Add(1);
                list1.Add(8);
                list1.Add(3);
                list1.Add(10);
                list1.Print();
                list1.HeapSort();
                list1.Print();
            }
        }
    }
}