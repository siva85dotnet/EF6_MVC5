using System;
using System.Collections.Generic;
using System.Linq;

namespace FindSecondHighestNumber
{
    public class Class1
    {
        public static void Main()
        {
            List<int> intLst = new List<int> { 5, 7, 3, 9, 4, 8, 2, 1, 6 };

            Console.WriteLine("Input list:");
            foreach (int i in intLst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            SortList(intLst, 0, intLst.Count);

            Console.WriteLine("\nSorted list:");
            foreach (int i in intLst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nSecond largest value in the list : {0}", intLst[1]);
            Console.Read();
        }


        public static void SortList(List<int> intList, int left, int right)
        {
            if (left < right)
            {
                int boundary = left;
                for (int i = left + 1; i < right; i++)
                {
                    if (intList[i] > intList[left])
                    {
                        Swap(intList, i, ++boundary);
                    }
                }

                Swap(intList, left, boundary);
                SortList(intList, left, boundary);
                SortList(intList, boundary + 1, right);
            }
        }

        private static void Swap(List<int> array, int left, int right)
        {
            int tmp = array[right];
            array[right] = array[left];
            array[left] = tmp;
        }

    }

        


}
