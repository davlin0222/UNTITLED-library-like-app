using System;
using Logic;

namespace Manual_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            test_storage();
            test_media();
        }

        private static void test_storage() {
            Book book = new Book("The Ranger's Apprentice", 200);
            Sound_track hello_there = new Sound_track("Hello there", 120);

            Storage media = new Storage();

            media.storage_add(book);
            media.storage_add(hello_there);

            Console.WriteLine(media.ToString());
        }

        private static void test_media() {
            Book book = new Book("The Ranger's Apprentice", 200);
            Console.WriteLine(book.Title.ToString());
            book.Title = "The Ranger's Apprentice 2";
            Console.WriteLine(book.Title.ToString());
            Console.WriteLine(book.Pages.ToString());

            Sound_track hello_there = new Sound_track("Hello there", 120);
            Console.WriteLine(hello_there.ToString());
        }
    }
}
