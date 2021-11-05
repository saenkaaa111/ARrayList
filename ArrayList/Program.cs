using System;

namespace ArrayList
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            ArrayList arrayList = new ArrayList(new int[3] { 2, 3, 4 });
            //ArrayList1111 arrayLis = new ArrayList1111(new int[0] { });
            arrayList.MoveElementsToRight(2, 6);
            //arrayList.Get(0);
            //arrayList.AddFirst(arrayLis);
            //arrayList.AddAt(0, arrayLis);
            //arrayList.AddLast(2);
            //arrayList.AddLast(4);
            //arrayList.AddLast(3);
            //arrayList.AddLast(64);
            //arrayList.AddLast(8);
            //arrayList.AddLast(6);
            ////arrayList.AddFirst(88);
            ////arrayList.AddFirst(1);
            ////arrayList.AddAt(2, 999);
            //////arrayList.Set(5, 88);
            //arrayList.RemoveFirst();
            //////arrayList.RemoveLast();
            //////arrayList.RemoveAt(11);
            ////arrayList.RemoveFirstMultiple(3);
            ////arrayList.RemoveLastMultiple(2);
            ////arrayList.RemoveAtMultiple(2, 3);
            ////arrayList.RemoveFirst(4);
            ////Console.WriteLine(  arrayList.Contains(55));
            ////Console.WriteLine(   arrayList.IndexOf(7));
            ////Console.WriteLine(arrayList.Get(2));
            ////arrayList.Reverse();
            ////Console.WriteLine(   arrayList.IndexOfMin());
            ////arrayList.SortDesc();
            int[] result = arrayList.ToArray();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine(arrayList.GetLength());

            //Console.ReadLine();




        }
    }
}
