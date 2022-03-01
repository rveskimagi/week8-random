using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\rvesk\samples\foods.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);


            foreach(string element in dataFromFile)

            {
                Console.WriteLine(element);
            }
        }
    }
}
