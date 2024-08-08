using System.Collections;

namespace Assignment
{
    internal class Program
    {
        public static void Reverse(ArrayList arrayList)
        {
            int start = 0;
            int end = arrayList.Count - 1;

            if (start < end)
            {
                var temp = arrayList[start];
                arrayList[start] = arrayList[end];
                arrayList[end] = temp;
                start++;
                end--;
            }
        }
        static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            return evenNumbers;
        }

        static void Main()
        {
            #region Part01
            //Write a Report about all Collections Given in the Session
            //and Compare [Structure, Time Complexity, and Business Case With Implemented Examples]

            //Array List: Resizable Array, Heterogeneous, Fast, Dynamic arrays with random access

            //List: Abstract data type, Depends on implementation, Homogeneous, Defining a contract for list implementation

            //Linked List: Nodes, Homogeneous, Dynamic Length, Slow, Frequent Insertions and deletions

            //Stack: LIFO, Slow, Function call management, undo mechanisms

            //Queue: FIFO, Slow, Task scheduling, handling requests in order
            #endregion

            #region Part02

            #region Q1
            ///You are given an ArrayList containing a sequence of elements.
            ///try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse.
            ///Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //Reverse(arrayList);

            //foreach (int item in arrayList)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Q2
            ///You are given a list of integers.
            ///Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> numbers = new List<int> { 22, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = EvenNumbers(numbers);

            //foreach (var num in evenNumbers)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region Q3
            ///3. implement a custom list called FixedSizeList<T> with a predetermined capacity.
            ///This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            ///Requirements:
            ///1.Create a generic class named FixedSizeList<T>.
            ///2. Implement a constructor that takes the fixed capacity of the list as a
            ///parameter.
            ///3.Implement an Add method that adds an element to the list, but
            ///throws an exception if the list is already full.
            ///4.Implement a Get method that retrieves an element at a specific index
            ///in the list but throws an exception for invalid indices.

            //try
            //{
            //    FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            //    fixedSizeList.Add(1);
            //    fixedSizeList.Add(2);
            //    fixedSizeList.Add(3);
            //    fixedSizeList.Add(4);
            //    fixedSizeList.Add(5);

            //    Console.WriteLine("Elements in the list:");
            //    for (int i = 0; i < fixedSizeList.Count; i++)
            //    {
            //        Console.WriteLine(fixedSizeList.Get(i));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #endregion
        }
    }
}
