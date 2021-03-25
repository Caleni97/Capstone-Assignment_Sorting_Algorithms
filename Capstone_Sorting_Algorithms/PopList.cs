using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace Capstone_Sorting_Algorithms
{
    class PopList
    {
        ArrayList List;
        ArrayList DesVal;
        int numDup = 0;
        public PopList()
        {
            List = new ArrayList();
            DesVal = new ArrayList();
        }

        public void Fixit()
        {
            Console.Write("Enter the size of the array\nMake the size larger than 16 but less than 500:  ");
            int size = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter the size of the array\nMake the size larger than 16 but less than 500:  ");
            } while (size <= 16);

            Random values = new Random();

            for (int x = 1; x <= size; x++)
            {
                DesVal.Add(values.Next(0, int.MaxValue));
            }
            int Dup = Convert.ToInt32(DesVal.Count * (0.3));

            for (int i = 0; i < Dup; i++)
            {
                for (int y = 0; y < Dup; y++)
                {
                    DesVal.Add(DesVal[i]);
                    numDup++;
                }
            }
            Shuffle(DesVal);
        }
        private void Shuffle(ArrayList point)
        {
            Random temp = new Random();
            for (int i = 0; i < point.Count; i++)
            {
                Object obj = point[i];
                int val = temp.Next(point.Count - i) + i;
                point[i] = point[val];
                point[val] = obj;
            }
        }

        public void WriteData(string FileName)
        {
            StreamWriter SW = new StreamWriter(FileName);

            for (int x = 0; x <= DesVal.Count - 1; x++)
            {
                SW.WriteLine(DesVal[x]);
            }

            SW.Close();
        }

        public void PopulateList(string FileName)
        {
            StreamReader Input = new StreamReader(FileName);
            while (!Input.EndOfStream)
            {
                string[] data = Input.ReadLine().Split(';');
                List.Add(int.Parse(data[0]));
            }
            Input.Close();
        }

        public void DisplayList()
        {
            for (int x = 0; x <= List.Count - 1; x++)
            {
                Console.WriteLine(List[x]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            newCount();
        }

        public void newCount()
        {
            int count = 0;
            for (int i = 0; i <= List.Count - 1; i++)
            {
                count = count + 1;
            }
            Console.WriteLine("New list size is: {0}", count);
            Console.WriteLine("The number of duplicates are {0}: ", numDup);
        }
    }
}
