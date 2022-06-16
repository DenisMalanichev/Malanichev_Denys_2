using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3OP
{   

    internal class Program
    {
      
        static void Main(string[] args)
        {  
           /* List<string> verse = new List<string>();
            verse.Add("Коли затихне гімн Росії,");
            verse.Add("І ураган зруйнує Кремль,");
            verse.Add("Коли помре і стане синім");
            verse.Add("Отой двоглавий їх орел,");
            verse.Add("Коли згорять усі \"матрьошкі\"");
            verse.Add("І здме їх попіл в Казахстан,");
            verse.Add("Я посумую, але трошки,");
            verse.Add("Що свідком того я не став.");
            verse = verse.OrderBy(x => x.Length).ToList();

            for (int i = 0; i < verse.Count; i++)
            {
                Console.WriteLine(verse[i]);
            }
            Console.Read();

            Class1 c1 = new Class1();
            c1.d();*/

            Class2 c2 = new Class2();
            c2.Str();
            Console.Read();
        }
    }
}
