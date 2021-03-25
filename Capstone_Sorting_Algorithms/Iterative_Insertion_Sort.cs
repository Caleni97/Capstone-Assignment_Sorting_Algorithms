using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Capstone_Sorting_Algorithms
{
    class Iterative_Insertion_Sort
    {
        Stopwatch time = new Stopwatch();
        int comparison = 0;
        int swaps = 0;

        public void Insertion(ArrayList A)
        {
            for (int x = 1; x <= A.Count - 1; x++)
                Insert((int)A[x], x - 1, A);
            display_List(A);
        }
        private void Insert(int value, int Last, ArrayList A)
        {
            time.Start();
            for (int x = Last; x >= 0; x--)
            {
                int cur = (int)A[x];

                comparison++;
                if ((value > cur))
                {
                    A[x + 1] = A[x]; swaps++;
                }
                else
                {
                    A[x + 1] = value;
                    return;
                }
            }
            A[0] = value;
            time.Stop();
        }

        public void display_List(ArrayList A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Number of swaps : {0}", swaps);
            Console.WriteLine();
            Console.WriteLine("Number of comparisons : {0}", comparison);
            Console.WriteLine();
            Console.WriteLine("Nmuber of Elapsed ticks : {0}", time.ElapsedTicks);
        }
    }
}
