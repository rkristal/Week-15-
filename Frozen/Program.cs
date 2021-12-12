using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
         
        class Christmas
        {
            string name;
            string wish;
            

            public Christmas(string _name, string _wish)
            {
                name = _name;
                wish = _wish;


                
            

            }

            public string Name
            {
                get { return name; }

            }

            public string Wish
            {
                get { return wish; }
            }

           
        }

        static void Main(string[] args)
        {
            List<Christmas> myWishes = new List<Christmas>();
            string[] FromFile = GetDataFromFile();

            foreach (string line in FromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Christmas newWish = new Christmas(tempArray[0], tempArray[1]);
                myWishes.Add(newWish);

            }

            foreach (Christmas FromList in myWishes)
            {
                Console.WriteLine($"{FromList.Name} wants  {FromList.Wish} for Christmas.");
            }
        }
   
            
            public static void DisplayElementsFromArray(string[] someArray)
            {
                foreach (string element in someArray)
                {
                    Console.WriteLine($"String from array: {element}");
                }

            }
            public static string[] GetDataFromFile()
            {
                string filePath = @"C:\Users\Admin\Downloads\frozen.txt";
                string[] dataFromFile = File.ReadAllLines(filePath);

                return dataFromFile;
            }
        }
    }

    

