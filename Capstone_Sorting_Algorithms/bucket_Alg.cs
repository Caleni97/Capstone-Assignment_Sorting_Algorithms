using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace Capstone_Sorting_Algorithms
{
    class bucket_Alg
    {
        Stopwatch Time = new Stopwatch();


        private int Max(ArrayList Arr)
        {
            int maxVal = -999;

            for (int x = 0; x <= Arr.Count - 1; x++)
            {
                if (maxVal < (int)Arr[x])
                {
                    maxVal = (int)Arr[x];
                }
            }
            return maxVal;
        }

        public void BucketSort(int numOfBuckets, ArrayList Arr, ref int swops, ref int comparisons)
        {
            Time.Start();

            SinglyLinkedList[] buckets = new SinglyLinkedList[numOfBuckets + 1];

            for (int i = 0; i <= buckets.Length - 1; i++)
            {
                buckets[i] = new SinglyLinkedList();
            }

            double ceil = Math.Ceiling(Max(Arr) * 1.0 / numOfBuckets);

            int sameCeil = Convert.ToInt32(ceil);

            /* Allocate each of the unsorted list items into the correct bucket.
             * Consider:  i) The bucket for a value is given by the floor of the value on which the sorting is being done
             *               divided by the range of a bucket.
             *           ii) Make sure that each bucket remains sorted as you add a new value (refer to the post-condition
             *               above for clarity).  */

            for (int x = 0; x <= Arr.Count - 1; x++)
            {
                int va = (int)Arr[x];

                double index = Math.Floor((int)Arr[x] * 1.0 / sameCeil);

                int sameIndex = Convert.ToInt32(index);

                SinglyLinkedList Temp = buckets[sameIndex];    // same as Temp = new SinglyLinkedList

                Cell start = Temp.getFirst();

                bool added = false;

                while ((start != null) && (!added))
                {
                    int val = (int)start.value();
                    comparisons++;
                    if (val > (int)Arr[x])
                    {
                        Temp.addBefore((int)Arr[x], start);
                        added = true;
                        break;
                    }
                    start = start.next();
                }

                if (!added)
                {
                    Temp.addLast(Arr[x]);
                }

            }

            /* Combine each bucket in sequence, overwriting the values in the original list.
             * Consider:  i) That buckets are not all the same length.
             *           ii) That you need to keep track of where the next slot in the original list is for a value
             *               to be overwritten. */

            int nrEl = Arr.Count - 1;
            for (int i = 0; i <= buckets.Length - 1; i++)
            {
                //Temp = buckets[i];

                //Cell cur = Temp.getFirst();

                Cell cur = buckets[i].getFirst();

                while (cur != null)
                {
                    Arr[nrEl] = (int)cur.value();
                    cur = cur.next();
                    nrEl--;

                }

            }
            Time.Stop();

            long time = Time.ElapsedTicks;
            Display(Arr, time, ref swops, ref comparisons);

        }

        private void Display(ArrayList Arr, long Time, ref int swops, ref int comparisons)
        {
            for (int x = 0; x <= Arr.Count - 1; x++)
            {
                Console.WriteLine("{0}", (int)Arr[x]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The number of elapsed ticks are: {0}", Time);
            Console.WriteLine();
            Console.WriteLine("The number of swops are: {0}", swops);
            Console.WriteLine();
            Console.WriteLine("The number of comparisons are: {0}", comparisons);
        }
    }
}

