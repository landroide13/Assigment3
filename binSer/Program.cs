using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace binSer
{
    class Program
    {
        static List<string> records = new List<string>();
        static int count = 0;
        //Setup Chronometer
        static Stopwatch chron = new Stopwatch();
        static int binSearch(List<string> li, string x)
        {
            int l = 0;
            int r = records.Count - 1;
            chron.Start();

            while (l <= r) 
            {
                //int m = l + (r - l) / 2;
                int m = (l + r) / 2;
                // Check the mid
                if (records[m] == x)
                {
                    chron.Stop();
                    return m;
                }
               
                if (records.IndexOf(records[m]) < records.IndexOf(x))
                    l = m + 1;
                else
                    r = m - 1;

                count++;    
            }
            return -1;
        }

        static void setData()
        {
            Console.WriteLine();
            Console.WriteLine("####### Please Enter The Name of the Movie ########");
            Console.WriteLine();

            string movieName = Console.ReadLine();
            string line;

            try
            {
                StreamReader sr = new StreamReader("/Users/landrade/Desktop/Whitecleffe/DataStructure/Assingment3/Projects/Pro2/files/movieTitles100K.txt");
            
                line = sr.ReadLine();

                while (line != null)
                {
                    records.Add(line);
                    line = sr.ReadLine();
                }

                //Binary Search
                int result = binSearch(records, movieName);
                if (result == -1)
                     Console.WriteLine("Element is not present in array");
                else
                    Console.WriteLine();
                    Console.WriteLine("Element is present at index " + result);
                    Console.WriteLine("Element is: " + records[result]);
                    Console.WriteLine();
                    Console.WriteLine("Total Milliseconds: " + chron.Elapsed.TotalMilliseconds);
                    Console.WriteLine("Iterations : " + count);

                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("########## Binary Search App #########");

            setData();

            Console.WriteLine(records.Count);
        }



    }
}
