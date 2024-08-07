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

            List<int> numbers = new List<int> { 22, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = EvenNumbers(numbers);

            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            #endregion

            #endregion
        }
    }
}
