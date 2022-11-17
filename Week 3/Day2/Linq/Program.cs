using System.Linq;
using System;



namespace Linq

{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] words = { "falcon", "eagle", "sky", "tree", "water" };

            var result =    from word in words
                            where word.Length > 5
                            select word + " hello world";
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("***********************************");


            var result1 = from word in words
                         where word.Length > 5
                         select word.Length;

            foreach (var word in result1)
            {
                Console.WriteLine(word);
            }
          
        }
    }
}