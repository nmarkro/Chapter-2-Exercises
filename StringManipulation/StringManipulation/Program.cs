using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.Write("Input search term: ");
            string term = Console.ReadLine();
            int index = message.ToLower().IndexOf(term.ToLower());
            Console.WriteLine(index > -1);
            if (index > -1)
            {
                int length = term.Length;
                Console.WriteLine("Index: " + index);
                Console.WriteLine("Length: " + length);

                string newMessage = message.Substring(0, index) + message.Substring(index + length, message.Length - (index + length));
                Console.WriteLine(newMessage);
            }
        }
    }
}
