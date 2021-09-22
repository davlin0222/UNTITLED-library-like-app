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
            Book book = new Book("The Ranger's Apprentice", 256);
            Sound_track hello_there = new Sound_track("Hello there", 2);
            Movie inception = new Movie("Inception", (2 * 60) + (28), "HD");

            Storage media = new Storage();

            media.storage_add(book);
            media.storage_add(hello_there);
            media.storage_add(inception);

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
