using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main1(string[] args)
        {
            List<int> intLst = new List<int> { 5, 7, 3, 9, 4, 8, 2, 1, 6 };

            foreach (int i in intLst)
            {
                Console.Write(i + " ");
            }

            SortList(intLst, 0, intLst.Count - 1);

            foreach (int i in intLst)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }

        private static void SortList(List<int> intLst, int left, int right)
        {
            int i = left, j = right;
            int pivot = intLst[(left + right) / 2];

            while (i <= j)
            {
                while (intLst[i] < pivot)
                {
                    i++;
                }
                while (intLst[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    intLst[i] = intLst[i] + intLst[j];
                    intLst[j] = intLst[i] - intLst[j];
                    intLst[i] = intLst[i] - intLst[j];

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                SortList(intLst, left, j);
            }

            if (i < right)
            {
                SortList(intLst, j, right);
            }
        }
    }
}