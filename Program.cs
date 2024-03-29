﻿using System;

namespace bookStore
{
    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId() { return _Id; }
        public string GetTitle() { return _Title; } 
        public string GetAuthor() { return _Author; } 

        public void SetId(int id) { _Id = id; }
        public void SetTitle(string title) { _Title = title; }
        public void SetAuthor(string author) { _Author = author; }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            // Default Constructor
            Book witcher = new Book();
            witcher.SetId(1);
            witcher.SetTitle("The Last Wish");
            witcher.SetAuthor("Andrzej Sapkowski");

            //Default user entered Constructor
            Book user = new Book();
            Console.WriteLine("Please enter in a book ID:");
            user.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter in a book Title");
            user.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter in a book Author");
            user.SetAuthor(Console.ReadLine());
            Console.WriteLine();

            //Parameterized Constructoor
            Book dracula = new Book(3, "Dracula", "Bram Stoker");

            //Parameterized user entered Constructor
            Console.WriteLine("Please enter in a book ID:");
            int paraId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in a book Title:");
            string paraTitle = Console.ReadLine();
            Console.WriteLine("Please enter in a book Author:");
            string paraAuthor = Console.ReadLine();
            Book para = new Book(paraId, paraTitle, paraAuthor);
            Console.WriteLine();

            //Calling Objects
            Console.WriteLine();
            displayBooks(witcher);
            Console.WriteLine();
            displayBooks(user);
            Console.WriteLine();
            displayBooks(dracula);
            Console.WriteLine();
            displayBooks(para);
        }

        static void displayBooks(Book book)
        {
            Console.WriteLine("Here is your book:");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
        }
    }
}
