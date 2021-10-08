using System;
using System.Collections.Generic;

namespace Persistance

{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> date = new();
            FileExtractContent file1 = new("C:\\Users\\prico\\Downloads\\weather.dat");
            date = file1.ImportData();
            foreach (List<string> line in date)
            {
                foreach (string word in line)
                    Console.Write(word + " ");
                Console.WriteLine(" ");
            }
        }
    }
}
