using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3OP
{
    internal class Class2
    {
        public void Str()
        {
            List<string> nums = new List<string>(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" } );
            List<string> lines = new List<string>();
            lines.Add("1test line");
            lines.Add("test line+");
            lines.Add("test line++");
            int L = 11;
            var selected = from l in lines where nums.Contains(l[0] + "") && l.Length == L select l;
            if(selected.Count() == 0)
                Console.WriteLine("Not found");
            else
                Console.WriteLine(selected.Last());
        }
    }
}
