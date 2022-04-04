using System;
using System.IO;
using System.Collections.Generic;


namespace binSer
{
    class Program
    {
        static List<string> records = new List<string>();
        static void getData()
        {
            Console.WriteLine("######## Please enter ID ########");

            string id = Console.ReadLine();

            string line;
            try
            {
                StreamReader sr = new StreamReader("/Users/landrade/Desktop/Whitecleffe/DataStructure/Assign1/Question1/listOfPatients.txt");
            
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
            Console.WriteLine("Hello World!");
        }



    }
}
