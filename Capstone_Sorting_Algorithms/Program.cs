using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Threading;

namespace Capstone_Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List_1 = new ArrayList();
            Recursive_IS IS = new Recursive_IS();
            Enhanced_IS algo = new Enhanced_IS();
            Quick_Sort quick = new Quick_Sort();
            bucket_Alg buck = new bucket_Alg();
            Improved_Insertion_Sort Insert = new Improved_Insertion_Sort();
            PopList List = new PopList();
            Iterative_Insertion_Sort IIS = new Iterative_Insertion_Sort();

            //Populting Array List with integers from textfile (testing functionality of algorithms)
            //StreamReader Input = new StreamReader("Test Data.txt");
            //while (!Input.EndOfStream)
            //{

            //    List_1.Add(int.Parse(Input.ReadLine()));
            //    //List_2.Add(int.Parse(Input.ReadLine()));



            //    x++;
            //    // Other lists to be populated at later stage
            //}
            int choice;
            char size;
            do
            {
                Console.Clear();
                Console.WriteLine("INDICATE THE SORTING ALGORITHM YOU WANT TO USE :");
                Console.WriteLine("0. Populate the list");
                Console.WriteLine("1. Recursive Insertion Sort");
                Console.WriteLine("2. Enhanced Insertion Sort");
                Console.WriteLine("3. Quick Sorrt");
                Console.WriteLine("4. Bucket Sort");
                Console.WriteLine("5. Improved Insertion Sort");
                Console.WriteLine("6. Iterative Insertion Sort");
                Console.WriteLine("9. TERMINATE PROCESSING");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    //add code for the implementation of 4 different textfiles of the different sizes
                    case 0:

                        Console.WriteLine("Enter capital S to create a new Small textfile\nEnter capital M to create a new Medium textfile\nEnter capital L to create a new Large textfile\nEnter capital V to create a new VeryLarge textfile");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        char inp = char.Parse(Console.ReadLine());
                        switch (inp)
                        {

                            case 'S':
                                List.Fixit();
                                List.WriteData("Small.txt");
                                List.PopulateList("Small.txt");

                                List.DisplayList();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                List.newCount();
                                break;

                            case 'M':
                                List.Fixit();
                                List.WriteData("Medium.txt");
                                List.PopulateList("Medium.txt");

                                List.DisplayList();

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                List.newCount();
                                break;

                            case 'L':
                                List.Fixit();
                                List.WriteData("Large.txt");
                                List.PopulateList("Large.txt");

                                List.DisplayList();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                List.newCount();
                                break;

                            case 'V':
                                List.Fixit();
                                List.WriteData("VeryLarge.txt");
                                List.PopulateList("VeryLarge.txt");


                                List.DisplayList();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                List.newCount();
                                break;
                        }
                        break;


                    case 1:
                        {
                            Console.WriteLine("Enter The size of list you want sorted :");
                            Console.WriteLine("s : Small");
                            Console.WriteLine("m : Meduim");
                            Console.WriteLine("l : Large");
                            Console.WriteLine("v : Very large");
                            size = char.Parse(Console.ReadLine());
                            switch (size)
                            {
                                case 's':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Small.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'm':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Medium.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;

                                    }
                                case 'l':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Large.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'v':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("VeryLarge.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Incorrect Option Selected");

                                        break;
                                    }
                            }
                            Console.Clear();
                            Console.WriteLine("Displaying the unsorted list");
                            Console.WriteLine();
                            for (int i = 0; i < List_1.Count; i++)
                            {
                                Console.WriteLine(List_1[i]);
                            }
                            Console.WriteLine("----------------------------------------------------------------------");
                            //Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Displaying the sorted List");
                            Console.WriteLine();
                            IS.doInsertion(List_1);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue :");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter The size of list you want sorted :");
                            Console.WriteLine("s : Small");
                            Console.WriteLine("m : Meduim");
                            Console.WriteLine("l : Large");
                            Console.WriteLine("v : Very large");
                            size = char.Parse(Console.ReadLine());
                            switch (size)
                            {
                                case 's':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Small.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'm':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Medium.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;

                                    }
                                case 'l':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Large.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'v':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("VeryLarge.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Incorrect Option Selected");

                                        break;
                                    }
                            }
                            Console.Clear();
                            Console.WriteLine("Displaying the unsorted list");
                            Console.WriteLine();
                            for (int i = 0; i < List_1.Count; i++)
                            {
                                Console.WriteLine(List_1[i]);
                            }
                            Console.WriteLine("----------------------------------------------------------------------");
                            //Thread.Sleep(2000);
                            //Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Displaying the sorted List");
                            Console.WriteLine();
                            algo.doEIS(List_1);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue :");
                            Console.ReadLine();
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter The size of list you want sorted :");
                            Console.WriteLine("s : Small");
                            Console.WriteLine("m : Meduim");
                            Console.WriteLine("l : Large");
                            Console.WriteLine("v : Very large");
                            size = char.Parse(Console.ReadLine());
                            switch (size)
                            {
                                case 's':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Small.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'm':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Medium.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;

                                    }
                                case 'l':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("Large.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'v':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();
                                        StreamReader input = new StreamReader("VeryLarge.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Incorrect Option Selected");

                                        break;
                                    }
                            }
                            Console.Clear();
                            Console.WriteLine("Displaying the unsorted list");
                            Console.WriteLine();
                            for (int i = 0; i < List_1.Count; i++)
                            {
                                Console.WriteLine(List_1[i]);
                            }
                            Console.WriteLine("----------------------------------------------------------------------");
                            //Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Displaying the sorted List");
                            Console.WriteLine();
                            quick.doQS(List_1);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue :");
                            Console.ReadLine();
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Enter The size of list you want sorted :");
                            Console.WriteLine("s : Small");
                            Console.WriteLine("m : Meduim");
                            Console.WriteLine("l : Large");
                            Console.WriteLine("v : Very large");
                            size = char.Parse(Console.ReadLine());
                            // Stopwatch Time = new Stopwatch();
                            int nrOfBuckets = 20;
                            switch (size)
                            {
                                case 's':

                                    StreamReader Input = new StreamReader("Small.txt");
                                    while (!Input.EndOfStream)
                                    {
                                        string[] data = Input.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input.Close();

                                    break;

                                case 'm':

                                    StreamReader Input_M = new StreamReader("Medium.txt");
                                    while (!Input_M.EndOfStream)
                                    {
                                        string[] data = Input_M.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input_M.Close();

                                    break;

                                case 'l':

                                    StreamReader Input_L = new StreamReader("Large.txt");
                                    while (!Input_L.EndOfStream)
                                    {
                                        string[] data = Input_L.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input_L.Close();

                                    break;

                                case 'v':

                                    StreamReader Input_V = new StreamReader("VeryLarge.txt");
                                    while (!Input_V.EndOfStream)
                                    {
                                        string[] data = Input_V.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input_V.Close();


                                    break;

                                default:
                                    {
                                        Console.WriteLine("Incorrect Option Selected");

                                        break;
                                    }

                            }
                            Console.Clear();
                            Console.WriteLine("Displaying the unsorted list");
                            Console.WriteLine();
                            for (int i = 0; i < List_1.Count; i++)
                            {
                                Console.WriteLine(List_1[i]);
                            }
                            Console.WriteLine("----------------------------------------------------------------------");
                            //Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Displaying the sorted List");
                            Console.WriteLine();
                            int swops_V = 0;
                            int comparisons_V = 0;

                            //  Time.Start();
                            buck.BucketSort(nrOfBuckets, List_1, ref swops_V, ref comparisons_V);
                            // Time.Stop();

                            //  buck.Display(List_1, Time.ElapsedTicks, ref swops_V, ref comparisons_V);

                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue :");
                            Console.ReadLine();


                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Enter The size of list you want sorted :");
                            Console.WriteLine("s : Small");
                            Console.WriteLine("m : Meduim");
                            Console.WriteLine("l : Large");
                            Console.WriteLine("v : Very large");
                            size = char.Parse(Console.ReadLine());
                            Stopwatch Time = new Stopwatch();

                            switch (size)
                            {
                                case 's':

                                    StreamReader Input = new StreamReader("Small.txt");
                                    while (!Input.EndOfStream)
                                    {
                                        string[] data = Input.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input.Close();

                                    break;

                                case 'm':

                                    StreamReader Input_M = new StreamReader("Medium.txt");
                                    while (!Input_M.EndOfStream)
                                    {
                                        string[] data = Input_M.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input_M.Close();

                                    break;

                                case 'l':

                                    //  ArrayList Arr_L = new ArrayList();

                                    StreamReader Input_L = new StreamReader("Large.txt");
                                    while (!Input_L.EndOfStream)
                                    {
                                        string[] data = Input_L.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input_L.Close();

                                    break;

                                case 'v':

                                    StreamReader Input_V = new StreamReader("VeryLarge.txt");
                                    while (!Input_V.EndOfStream)
                                    {
                                        string[] data = Input_V.ReadLine().Split(';');
                                        List_1.Add(int.Parse(data[0]));
                                    }
                                    Input_V.Close();


                                    break;

                                default:
                                    {
                                        Console.WriteLine("Incorrect Option Selected");

                                        break;
                                    }

                            }
                            Console.Clear();
                            Console.WriteLine("Displaying the unsorted list");
                            Console.WriteLine();
                            for (int i = 0; i < List_1.Count; i++)
                            {
                                Console.WriteLine(List_1[i]);
                            }
                            Console.WriteLine("----------------------------------------------------------------------");
                            //Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Displaying the sorted List");
                            Console.WriteLine();


                            int swops = 0, comparisons = 0;
                            Stopwatch timer = new Stopwatch();
                            //   timer.Start();
                            Insert.Insert(List_1, ref swops, ref comparisons);
                            //  timer.Stop();
                            //  Insert.DisplayList(List_1, swops, comparisons, timer.ElapsedTicks);



                            Console.ReadLine();

                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Enter The size of list you want sorted :");
                            Console.WriteLine("s : Small");
                            Console.WriteLine("m : Meduim");
                            Console.WriteLine("l : Large");
                            Console.WriteLine("v : Very large");
                            size = char.Parse(Console.ReadLine());
                            switch (size)
                            {
                                case 's':
                                    {
                                        if (!(List_1.Count == 0))
                                            List_1.Clear();

                                        StreamReader input = new StreamReader("Small.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'm':
                                    {
                                        StreamReader input = new StreamReader("Medium.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;

                                    }
                                case 'l':
                                    {
                                        StreamReader input = new StreamReader("Large.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                case 'v':
                                    {
                                        StreamReader input = new StreamReader("VeryLarge.txt");
                                        while (!input.EndOfStream)
                                            List_1.Add(int.Parse(input.ReadLine()));
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Incorrect Option Selected");

                                        break;
                                    }
                            }
                            Console.Clear();
                            Console.WriteLine("Displaying the unsorted list");
                            Console.WriteLine();
                            for (int l = 0; l < List_1.Count; l++)
                            {
                                Console.WriteLine(List_1[l]);
                                // items++;
                            }
                            // Console.WriteLine("Number of Elements: {0}", items);
                            Console.WriteLine("----------------------------------------------------------------------");
                            //   Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Displaying the sorted List");
                            Console.WriteLine();
                            IIS.Insertion(List_1);
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue :");
                            Console.ReadLine();


                            break;
                        }

                    case 9:

                        Console.WriteLine("Procesing terminated - Press Enter to continue");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Incoreect selction press enter to continue");
                        Console.ReadLine();
                        break;


                }

                Console.ReadLine();

            } while (choice != 9);



        }
    }
    
}
