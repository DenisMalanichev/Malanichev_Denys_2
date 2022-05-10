using Newtonsoft.Json;
using System;

namespace lab2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeClass tc = new TimeClass(10, 12, 11);

            string JsonData = JsonConvert.SerializeObject(tc);
            
            var tc2 = JsonConvert.DeserializeObject<TimeClass>(JsonData);

            Console.WriteLine(tc2.Hours);
            Console.ReadKey();
        }
    }
}
