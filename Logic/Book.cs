using System;

namespace Logic
{
    public class Book : Media
    {
        public int Pages{get; set;}

        public Book(string title, int pages) : base(title) {
            this.Pages = pages;
        }
        
        public override string ToString() {
            return $"{Title}\tSound track\t{Pages} pages";
        }
    }
}
