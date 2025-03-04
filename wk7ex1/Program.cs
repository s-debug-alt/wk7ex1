using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk7ex1
{
    internal class Program
    {// method to count words
        public static int CountWords(string fileName)
        {
            // delcare int
            int wordCount = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                // read file
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(','); // split word by comma
                    wordCount++;
                }
            }
                return wordCount;
            }
        static void Main(string[] args)
        {// to text the program
            string fileName = "test.txt";
            // to count the words
            int wordCount = CountWords(fileName);
            // show word count
            Console.WriteLine   (wordCount);
        }
    }
}
