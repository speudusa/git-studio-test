using System;
using System.Collections.Generic;

namespace git_studio_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Howdy!");

            List<string> name = new List<string>();
            {
                name.Add("Willow");
                name.Add("Alyce");
            }

            foreach(string n in name)
            {
                Console.WriteLine(n);
            }
        }
    }
}
