using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace linSear
{
    class Program
    {
        static List<string> records = new List<string>();
        //Counter iterations
        static int count = 0;
        //Setup Chronometer
        static Stopwatch chron = new Stopwatch();
        public static int linSearch(List<string> li, string x)
        {
            int n = li.Count;
            chron.Start();

            for (int i = 0; i < n; i++)
            {
                if (li[i] == x)
                {
                    return i;
                }
                count++;
            }
            chron.Stop();
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

                //Linear Search
                int result = linSearch(records, movieName);
                if (result == -1)
                     Console.WriteLine("Element is not present in array");
                else
                    Console.WriteLine("Element is present at index " + result);
                    Console.WriteLine("Element is: " + records[result]);
                    Console.WriteLine("Total Milliseconds: " + chron.Elapsed.TotalMilliseconds);
                    Console.WriteLine();
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
            Console.WriteLine("########## Linear Search App #########");

            Console.WriteLine();

            setData();
        }
    }
}
