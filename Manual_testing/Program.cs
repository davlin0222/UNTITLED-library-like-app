using System;
using Logic;

namespace Manual_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage media = new Storage();

            media.storage_add("Item 1");

            Console.WriteLine(media.ToString());
        }
    }
}
