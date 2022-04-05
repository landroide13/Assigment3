using System;
using System.IO;
using System.Collections.Generic;

namespace linSear
{
    class Program
    {
        static List<string> records = new List<string>();

        public static int linSearch(List<string> li, string x)
        {
            int n = li.Capacity;
            for (int i = 0; i < n; i++)
            {
                if (li[i] == x)
                    return i;
            }
            return -1;
        }
        static void setData()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("/Users/landrade/Desktop/Whitecleffe/DataStructure/Assingment3/Projects/Pro2/files/movieTitles20.txt");
            
                line = sr.ReadLine();

                while (line != null)
                {
                    records.Add(line);
                    
                    line = sr.ReadLine();
                }

                //  foreach(object mv in records)
                // {
                //     Console.WriteLine("Arr " + mv);
                // }

            Console.WriteLine(records[10]);

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

            setData();



        }
    }
}
