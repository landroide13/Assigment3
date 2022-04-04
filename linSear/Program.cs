﻿using System;
using System.IO;
using System.Collections.Generic;

namespace linSear
{
    class Program
    {
        static List<string> records = new List<string>();
        static void getData()
        {
            Console.WriteLine("######## Please enter ID ########");

            //string id = Console.ReadLine();

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

                 foreach(string el in records)
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
