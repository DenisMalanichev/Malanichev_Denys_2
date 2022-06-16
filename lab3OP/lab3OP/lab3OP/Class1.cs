using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace lab3OP
{
    internal class Class1
    {
        public Dictionary<int, int> dict { get; set; }
        public void d()
        {
            dict = new Dictionary<int, int>();
            dict.Add(1, 84);
            dict.Add(2, 90);
            dict.Add(3, 95);
            dict.Add(4, 100);
            List<int> keys = dict.Keys.ToList();
            Console.WriteLine("Enter length: ");
            int len = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i] < len)
                {
                    dict.Remove(keys[i]);
                    keys.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < keys.Count; i++)
            {          
                 Console.WriteLine(keys[i] + " - " + dict[keys[i]]);
            }
            File.WriteAllText("lab.json", JsonConvert.SerializeObject(this));
        }
    }
}
