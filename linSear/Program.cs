using System;
using System.IO;
using System.Collections.Generic;

namespace linSear
{
    class Program
    {
        static List<Movie> records = new List<Movie>();
        static void getData()
        {
            //Console.WriteLine("######## Please enter ID ########");

            //string id = Console.ReadLine();

            string line;
            try
            {
                StreamReader sr = new StreamReader("/Users/landrade/Desktop/Whitecleffe/DataStructure/Assingment3/Projects/Pro2/files/movieTitles100K.txt");
            
                line = sr.ReadLine();

                while (line != null)
                {
                    Movie mv = new Movie();
                    mv.Name = line;
                    records.Add(mv);
                    
                    line = sr.ReadLine();
                }

                 foreach(object el in records)
                {
                    Console.WriteLine("Arr " + el);
                }

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

            getData();



        }
    }
}
