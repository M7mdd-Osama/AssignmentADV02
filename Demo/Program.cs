using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array List
            //ArrayList arrayList = new ArrayList();
            //arrayList => size 0
            //arrayList => Capacity 0
            //arrayList => Count 0

            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");

            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] {3,4});
            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");
            //arrayList.Add(2);
            //Console.WriteLine($"Count = {arrayList.Count} , Capacity = {arrayList.Capacity}");

            //ArrayList arrayList2 = new ArrayList(5);
            //arrayList2.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            //Console.WriteLine($"Count = {arrayList2.Count} , Capacity = {arrayList2.Capacity}");
            //arrayList2.TrimToSize();
            //Console.WriteLine($"Count = {arrayList2.Count} , Capacity = {arrayList2.Capacity}");

            //arrayList2.Add("Mohamed"); //Heterogeneous List

            //foreach(/*var*/int item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.AddRange(new int[] { 3, 4, 5 });
            //Console.WriteLine($"Count = {list.Count} , Capacity = {list.Capacity}");
            //list.TrimExcess();
            //Console.WriteLine($"Count = {list.Count} , Capacity = {list.Capacity}");

            //List<int> list2 = new List<int>(5) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //Console.WriteLine($"Count = {list2.Count} , Capacity = {list2.Capacity}");

            //foreach (int i in list2)
            //    Console.WriteLine(i);
            #endregion        
        }
    }
}
