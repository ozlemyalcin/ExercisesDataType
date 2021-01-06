using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceStr = "Alice was beginning to get very tired of sitting by her sister on the bank,and of having nothing to do: once or twice she had peeped into the book her sister was reading but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Search term: ");
            string word = Console.ReadLine();


            string newAliceStr = aliceStr.ToLower();
            
            //bool found = aliceStr.ToLowe().Contains(word);
            //Console.WriteLine(found);


            bool a = newAliceStr.Contains(word);
            Console.WriteLine(a);

            Console.WriteLine(newAliceStr.Length);

            int i = newAliceStr.IndexOf(word);

            Console.WriteLine(i);

            string lastAlicestr = newAliceStr.Remove(i,word.Length);
            Console.WriteLine(lastAlicestr);

            Console.WriteLine(lastAlicestr.Length);






        }
    }
}
