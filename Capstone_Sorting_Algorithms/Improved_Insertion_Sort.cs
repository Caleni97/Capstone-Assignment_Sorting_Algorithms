using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Capstone_Sorting_Algorithms
{
    class Improved_Insertion_Sort
    {
        Stopwatch Time = new Stopwatch();

        public void Insert(ArrayList List, ref int swops, ref int comparisons)
        {
            Time.Start();

            int Pos = 0;
            int val = (int)List[Pos];

            for (int x = 1; x <= List.Count - 1; x++)
            {
                comparisons++;
                if (((int)List[x]).CompareTo(val) > 0)
                {
                    Pos = x;
                    val = (int)List[Pos];

                }
            }
            for (int x = Pos; x > 0; x--)
            {
                List[x] = List[x - 1];

                swops++;
            }
            List[0] = val;
            swops++;

            for (int x = 2; x <= List.Count - 1; x++)
            {
                int y = x;
                int value = (int)List[y];
                int prevOne = (int)List[y - 1];

                comparisons++;
                while (prevOne.CompareTo(value) < 0)
                {
                    comparisons++;

                    Swop(List, y - 1, y);
                    swops++;

                    y = y - 1;
                    value = (int)List[y];
                    prevOne = (int)List[y - 1];
                }

            }
            Time.Stop();

            long time = Time.ElapsedTicks;

            DisplayList(List, ref swops, ref comparisons, time);

        }
        private void Swop(ArrayList List, int x, int y)
        {
            Object temp = List[y];
            List[y] = List[x];
            List[x] = temp;

        }

        private void DisplayList(ArrayList List, ref int swops, ref int comparisons, long timer)
        {

            for (int i = 0; i <= List.Count - 1; i++)
            {
                Console.WriteLine(List[i]);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Number of comparisons : {0}", comparisons);
            Console.WriteLine();
            Console.WriteLine("Number of swops : {0}", swops);
            Console.WriteLine();
            Console.WriteLine("Number of Elapsed ticks : {0}", timer);

        }
    }
}

