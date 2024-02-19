using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length;
            Console.WriteLine(result);
            var result2 = sentence.Clone();
            Console.WriteLine(result2);
            Console.WriteLine(sentence.EndsWith("ğ"));
            Console.WriteLine(sentence.StartsWith("M"));
            Console.WriteLine(sentence.IndexOf(" "));
            Console.WriteLine(sentence.LastIndexOf(" "));
            Console.WriteLine(sentence.Insert(0, "Hello,"));
            Console.WriteLine(sentence.Substring(3));
            Console.WriteLine(sentence.Substring(3,4));
            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.Replace(" ","-"));
            Console.WriteLine(sentence.Remove(2));
            Console.WriteLine(sentence.Remove(2,5));

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city);
            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
