using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Capstone_Sorting_Algorithms
{
    class Enhanced_IS
    {
        Stopwatch time = new Stopwatch();

        public int swop = 0, comparison = 0;
        public void doEIS(ArrayList Integers)
        {
            EIS(Integers);
            display_List(Integers);
        }
        private void EIS(ArrayList Integers)
        {
            time.Start();
            int i = 1, current = 0, n = Integers.Count;
            comparison++;
            while (i < n)
            {
                int j = i;
                comparison++;
                if ((int)Integers[i] >= (int)Integers[0])
                {
                    ++comparison;
                    while (j > 0)
                    {
                        swap(j, j - 1, Integers);
                        j--;

                    }
                    i++;
                }
                else if ((int)Integers[i] <= (int)Integers[i - 1])
                {
                    comparison++;
                    i++;
                    continue;
                }
                else
                {
                    current = BinarySearch(Integers, (int)Integers[i], i);
                    if (current == 0)
                    {
                        comparison++;
                        while (j > current + 1)
                        {
                            swap(j, j - 1, Integers);
                            j--;
                        }
                    }
                    else
                    {
                        comparison++;
                        while (j > current)
                        {
                            swap(j, j - 1, Integers);
                            j--;
                        }
                    }
                    i++;
                }
            }
            time.Stop();
        }

        private int BinarySearch(ArrayList Integers, int i, int j)
        {
            int f = 0; // first 
            int l = j - 1; // last 
            int m; // middle
            while (f <= l)
            {
                m = (f + l) / 2;
                int cur = (int)Integers[m];
                if (m == 0)
                    return 0;
                else if (cur == i)
                    return m;
                else if (i > (int)Integers[m + 1] && i < (int)Integers[m])
                    return m + 1;
                else if (i > (int)Integers[m] && i < (int)Integers[m - 1])
                    return m;
                else if (i < cur)
                    f = m + 1;
                else
                    l = m - 1;

            }
            return -1;
        }

        private void swap(int a, int b, ArrayList Integers) // 35
        {
            int temp = (int)Integers[a];
            Integers[a] = Integers[b];
            Integers[b] = temp;
            ++swop;

        }
        public void display_List(ArrayList List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Number of swops : {0}", swop);
            Console.WriteLine();
            Console.WriteLine("Number of comparisons : {0}", comparison);
            Console.WriteLine();
            Console.WriteLine("Nmuber of Elapsed ticks : {0}", time.ElapsedTicks);
        }
        //public void IS(ArrayList Integers)
        //{
        //    int n = Integers.Count; //1 
        //    int i = 1, j; //2
        //    outer:
        //    if ((int)Integers[i] < (int)Integers[i - 1]) //3
        //    {
        //        if ((int)Integers[i] < (int)Integers[0]) //4
        //        {
        //            j = 0; //5
        //            swap(i, j, Integers); // and 5 (go-to 35)
        //        }
        //        else // 6 
        //        {
        //            j = i / 2; //6
        //            if ((int)Integers[i] < (int)Integers[j]) // 6 and 10
        //            {
        //                while ((j - 1) >= 0) //16
        //                {
        //                    j = j - 2; // 17
        //                    if ((int)Integers[i] > (int)Integers[j])  // and 17
        //                    {
        //                        if ((int)Integers[i] < (int)Integers[j + 1]) // 18
        //                        {
        //                            j = j + 1; // 19 
        //                            swap(i, j, Integers); // and 19 (go-to 35)

        //                        }
        //                        else
        //                        {
        //                            j = j + 2; // 20
        //                            swap(i, j, Integers); // and 20 (go-to 35)
        //                        }

        //                    }
        //                    // 21 (ending above if)
        //                    else if (Integers[i] == Integers[j]) // 22
        //                    {
        //                        j = j + 1;// 23
        //                        swap(i, j, Integers); // and 23 (go-to 35)
        //                    }
        //                    else // 24 
        //                        break; // or return should break not work

        //                }
        //            }
        //            else if (Integers[i] == Integers[j]) // 11
        //            {
        //                j = j + 1; // 12 
        //                swap(i, j, Integers); // and 12 (go-to 35)

        //            }
        //            // 13 end above else if
        //            else // 14 (go-to 25)
        //            {
        //                while (((i - 1) - j) >= 0) // 25
        //                {
        //                    j = j + 2; // 26
        //                    if ((int)Integers[i] < (int)Integers[j]) // and 26
        //                    {
        //                        if ((int)Integers[i] < (int)Integers[j - 1]) // 27
        //                        {
        //                            j = j - 1; // 28 
        //                            swap(i, j, Integers); // 28 and (go-to 35)
        //                        }
        //                        else //29
        //                        {
        //                            j = j + 0; // 29  not sure this is what is meant
        //                            swap(i, j, Integers); // (go-to 35)
        //                        }

        //                    }
        //                    // 30 end above if 
        //                    else if (Integers[i] == Integers[j]) // 31
        //                    {
        //                        j = j + 1; // 32
        //                        swap(i, j, Integers); // 32 and (go-to 35)

        //                    }
        //                    else //33
        //                        break;
        //                }

        //            }
        //            // 34 end if
        //            //35
        //            swap(i, j, Integers);
        //            j++; //36
        //        }
        //        // end if 7
        //    }
        //    else
        //    {
        //        i++; // 8
        //        goto outer; // 8 and repeat 3
        //    }
        //    // 9 end if
        //    while (j == (i-1))
        //    {
        //        i++;
        //        goto outer;
        //    }
        //}
    }
}
