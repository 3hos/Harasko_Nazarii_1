using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var rand = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(-100,100));
                Console.Write(list[i] + " ");
            }
            int Av = (int)list.Where(x=>x<0).Average();
            list[list.IndexOf(list.Min())] = Av;
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(list[i] + " ");
            }


            //---------------------------------


            Console.WriteLine("\n-------------------\n");
            var people = new Dictionary<int, string>()
            {
                { 5, "Tom"},
                { 3, "Sam"},
                { 11, "Bob"}
            };
            List<int> keys = new List<int>(); 
            List<string> Values = new List<string>();
            foreach (var person in people)
            {
                keys.Add(person.Key);
                Values.Add(person.Value);
            }
            foreach(var key in keys)
            {
                Console.Write(key + "; ");
            }
            Console.WriteLine("\n");
            foreach (var value in Values)
            {
                Console.Write(value + "; ");
            }
            Console.WriteLine("\n-------------------\n");

            //---------------------------------

            List<string> strs = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            int co = strs.Sum(x=>x.Count());
            Console.WriteLine(co);

        }
    }
}
