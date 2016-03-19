using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class Class1
{
    public static void Main1()
    {
        List<int> intLst = new List<int> { 5, 7, 3, 9, 4, 8, 2, 1, 6 };
        foreach (int i in intLst)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        SortList(intLst, 0, intLst.Count);

        foreach (int i in intLst)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void SortList(List<int> intLst, int left, int right)
    {
        if (left < right)
        {
            int pivotIdx = MyPartition(intLst, left, right);
            SortList(intLst, left, pivotIdx - 1);
            SortList(intLst, pivotIdx, right);
        }
    }

    static int MyPartition(List<int> intLst, int left, int right)
    {
        int start = left;
        int pivot = intLst[start];
        left++;
        right--;

        while (true)
        {
            while (left <= right && intLst[left] <= pivot)
                left++;

            while (left <= right && intLst[right] > pivot)
                right--;

            if (left > right)
            {
                intLst[start] = intLst[left - 1];
                intLst[left - 1] = pivot;

                return left;
            }


            intLst[left] = intLst[left] + intLst[right];
            intLst[right] = intLst[left] - intLst[right];
            intLst[left] = intLst[left] - intLst[right];

        }

        
    }

}