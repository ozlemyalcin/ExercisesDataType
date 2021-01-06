using System;

namespace StringAlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceStr = "Alice was beginning to get very tired of sitting by her sister on the bank,and of having nothing to do: once or twice she had peeped into the book her sister was reading but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";



            //Console.WriteLine(aliceStr.ToLower());
            string newAliceStr = aliceStr.ToLower();
            //int i = newAliceStr.IndexOf("alice");
            //Console.WriteLine(i);

            bool a = newAliceStr.Contains("alice");
            Console.WriteLine(a);









            //string word = "very";
            //Console.WriteLine(aliceStr.IndexOf(word));

        }
    }
}
