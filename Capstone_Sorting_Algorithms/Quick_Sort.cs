using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace Capstone_Sorting_Algorithms
{
    class Quick_Sort
    {
        Stopwatch time = new Stopwatch();
        int swops = 0, comparisons = 0;
        public void doQS(ArrayList List)
        {
            QS(List, 0, List.Count - 1);
            display_List(List);
        }
        private void QS(ArrayList Integers, int start, int end)
        {
            time.Start();
            comparisons++;
            if (start >= end)
                return;
            int piv = (int)Integers[start];
            int l = start;
            int h = end;
            while (true)
            {
                while ((int)Integers[h] <= piv)
                {
                    h--;
                    comparisons++;
                    if (h <= l)
                        break;
                }
                comparisons++;
                if (h <= l)
                {
                    swops++;
                    Integers[l] = piv;
                    break;
                }
                swops++;
                Integers[l] = Integers[h];
                l++;
                while ((int)Integers[l] > piv)
                {
                    l++;
                    comparisons++;
                    if (l >= h)
                        break;
                }
                comparisons++;
                if (l >= h)
                {
                    l = h;
                    swops++;
                    Integers[h] = piv;
                    break;
                }
                swops++;
                Integers[h] = Integers[l];
            }
            QS(Integers, start, l - 1);
            QS(Integers, l + 1, end);
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
