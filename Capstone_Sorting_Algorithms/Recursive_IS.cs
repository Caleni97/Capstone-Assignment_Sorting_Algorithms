using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Capstone_Sorting_Algorithms
{
    class Recursive_IS
    {
        Stopwatch time = new Stopwatch();
        int swops = 0, comparisons = 0;
        public void doInsertion(ArrayList Integers)
        {
            IS_Recursive(Integers, Integers.Count);
            display_List(Integers);
        }
        private void IS_Recursive(ArrayList Integers, int N)
        {
            time.Start();
            if (N <= 1)
                return;

            IS_Recursive(Integers, N - 1);
            int last = (int)Integers[N - 1];
            int j = N - 2;
            comparisons++;
            while (j >= 0 && (int)Integers[j] < last)
            {
                Integers[j + 1] = Integers[j];
                j--;
                swops++;
            }
            Integers[j + 1] = last;
            time.Stop();
        }


        public void display_List(ArrayList List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Number of swops : {0}", swops);
            Console.WriteLine();
            Console.WriteLine("Number of comparisons : {0}", comparisons);
            Console.WriteLine();
            Console.WriteLine("Nmuber of Elapsed ticks : {0}", time.ElapsedTicks);
        }
    }
}
